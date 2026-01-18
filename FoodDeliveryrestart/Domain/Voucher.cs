namespace FoodDeliveryrestart.Domain
{
    public class Voucher : BaseDomainModel
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string DiscountType { get; set; } = "Percentage"; // "Percentage" or "Fixed" or "FreeDelivery"
        public decimal DiscountValue { get; set; } // e.g., 20 for 20% or 5 for $5 off
        public decimal? MinimumOrder { get; set; } // Minimum order amount to use voucher
        public bool IsActive { get; set; } = true;
        public DateTime? ExpiryDate { get; set; }

        // Navigation
        public ICollection<UserVoucher> UserVouchers { get; set; } = new List<UserVoucher>();
    }
}
