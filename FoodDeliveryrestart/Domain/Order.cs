using System;

namespace FoodDeliveryrestart.Domain
{
    public class Order : BaseDomainModel
    {
        public DateTime DateTime { get; set; } = DateTime.UtcNow;
        public string? Status { get; set; }
        public decimal TotalAmount { get; set; }

        // ✅ Delivery tracking (use int to match DB int)
        public int DeliveryStage { get; set; } = 0;  // 0..3
        public DateTime? DeliveryStartedUtc { get; set; }
        public DateTime? DeliveryStageUpdatedUtc { get; set; }

        // Foreign Keys
        public int UserId { get; set; }
        public int GroupOrderId { get; set; }

        // Navigation
        public User? User { get; set; }
        public GroupOrder? GroupOrder { get; set; }

        public ICollection<OrderItem>? OrderItems { get; set; }
        public Payment? Payment { get; set; }
    }
}
