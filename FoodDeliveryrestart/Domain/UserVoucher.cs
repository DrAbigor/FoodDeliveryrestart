namespace FoodDeliveryrestart.Domain
{
    public class UserVoucher : BaseDomainModel
    {
        public string UserId { get; set; } = string.Empty; // Identity user ID
        public int VoucherId { get; set; }
        public DateTime ClaimedAt { get; set; } = DateTime.UtcNow;
        public bool IsUsed { get; set; } = false;
        public DateTime? UsedAt { get; set; }
        public int? OrderId { get; set; } // The order where voucher was used

        // Navigation
        public Voucher? Voucher { get; set; }
        public Order? Order { get; set; }
    }
}
