using FoodDeliveryrestart.Data;
using FoodDeliveryrestart.Domain;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryrestart.Services;

public class VoucherService
{
    private readonly IDbContextFactory<FoodDeliveryrestartContext> _dbFactory;

    public VoucherService(IDbContextFactory<FoodDeliveryrestartContext> dbFactory)
    {
        _dbFactory = dbFactory;
    }

    /// <summary>
    /// Get all active vouchers that haven't expired.
    /// </summary>
    public async Task<List<Voucher>> GetAvailableVouchersAsync()
    {
        await using var db = await _dbFactory.CreateDbContextAsync();
        return await db.Voucher
            .Where(v => v.IsActive && (v.ExpiryDate == null || v.ExpiryDate > DateTime.UtcNow))
            .OrderBy(v => v.Id)
            .ToListAsync();
    }

    /// <summary>
    /// Get a user's claimed vouchers that haven't been used yet.
    /// </summary>
    public async Task<List<UserVoucher>> GetUserVouchersAsync(string userId)
    {
        if (string.IsNullOrEmpty(userId)) return new List<UserVoucher>();

        await using var db = await _dbFactory.CreateDbContextAsync();
        return await db.UserVoucher
            .Include(uv => uv.Voucher)
            .Where(uv => uv.UserId == userId && !uv.IsUsed)
            .OrderByDescending(uv => uv.ClaimedAt)
            .ToListAsync();
    }

    /// <summary>
    /// Get voucher IDs that a user has claimed (but not yet used).
    /// </summary>
    public async Task<HashSet<int>> GetClaimedVoucherIdsAsync(string userId)
    {
        if (string.IsNullOrEmpty(userId)) return new HashSet<int>();

        await using var db = await _dbFactory.CreateDbContextAsync();
        var ids = await db.UserVoucher
            .Where(uv => uv.UserId == userId && !uv.IsUsed)
            .Select(uv => uv.VoucherId)
            .ToListAsync();

        return ids.ToHashSet();
    }

    /// <summary>
    /// Claim a voucher for a user. Returns true if successful, false if already claimed.
    /// </summary>
    public async Task<(bool Success, string Message)> ClaimVoucherAsync(string userId, int voucherId)
    {
        if (string.IsNullOrEmpty(userId))
            return (false, "User not authenticated.");

        await using var db = await _dbFactory.CreateDbContextAsync();

        // Check if voucher exists and is active
        var voucher = await db.Voucher.FindAsync(voucherId);
        if (voucher == null || !voucher.IsActive)
            return (false, "Voucher is not available.");

        if (voucher.ExpiryDate.HasValue && voucher.ExpiryDate < DateTime.UtcNow)
            return (false, "Voucher has expired.");

        // Check if already claimed
        var existing = await db.UserVoucher
            .FirstOrDefaultAsync(uv => uv.UserId == userId && uv.VoucherId == voucherId && !uv.IsUsed);

        if (existing != null)
            return (false, "You have already claimed this voucher!");

        // Claim the voucher
        var userVoucher = new UserVoucher
        {
            UserId = userId,
            VoucherId = voucherId,
            ClaimedAt = DateTime.UtcNow,
            IsUsed = false,
            DateCreated = DateTime.UtcNow,
            DateUpdated = DateTime.UtcNow,
            CreatedBy = userId,
            UpdatedBy = userId
        };

        db.UserVoucher.Add(userVoucher);
        await db.SaveChangesAsync();

        return (true, "Voucher claimed successfully!");
    }

    /// <summary>
    /// Mark a user voucher as used and associate it with an order.
    /// </summary>
    public async Task<bool> UseVoucherAsync(int userVoucherId, int orderId)
    {
        await using var db = await _dbFactory.CreateDbContextAsync();

        var userVoucher = await db.UserVoucher.FindAsync(userVoucherId);
        if (userVoucher == null || userVoucher.IsUsed)
            return false;

        userVoucher.IsUsed = true;
        userVoucher.UsedAt = DateTime.UtcNow;
        userVoucher.OrderId = orderId;
        userVoucher.DateUpdated = DateTime.UtcNow;

        await db.SaveChangesAsync();
        return true;
    }

    /// <summary>
    /// Calculate the discount amount for a voucher given a subtotal.
    /// </summary>
    public decimal CalculateDiscount(Voucher voucher, decimal subtotal)
    {
        if (voucher == null) return 0;

        // Check minimum order requirement
        if (voucher.MinimumOrder.HasValue && subtotal < voucher.MinimumOrder.Value)
            return 0;

        return voucher.DiscountType switch
        {
            "Percentage" => subtotal * (voucher.DiscountValue / 100),
            "Fixed" => voucher.DiscountValue,
            "FreeDelivery" => 0, // Free delivery handled separately
            _ => 0
        };
    }

    /// <summary>
    /// Check if a voucher provides free delivery for the given subtotal.
    /// </summary>
    public bool IsFreeDeliveryApplicable(Voucher? voucher, decimal subtotal)
    {
        if (voucher == null) return false;
        if (voucher.DiscountType != "FreeDelivery") return false;

        return !voucher.MinimumOrder.HasValue || subtotal >= voucher.MinimumOrder.Value;
    }

    /// <summary>
    /// Get a voucher by its code.
    /// </summary>
    public async Task<Voucher?> GetVoucherByCodeAsync(string code)
    {
        if (string.IsNullOrEmpty(code)) return null;

        await using var db = await _dbFactory.CreateDbContextAsync();
        return await db.Voucher
            .FirstOrDefaultAsync(v => v.Code == code && v.IsActive);
    }
}
