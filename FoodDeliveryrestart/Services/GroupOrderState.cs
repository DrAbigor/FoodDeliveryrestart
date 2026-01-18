namespace FoodDeliveryrestart.Services
{
    public class GroupOrderState
    {
        // The currently active group order (if any)
        public int? GroupOrderId { get; set; }

        // The shareable code users type to join
        public string? GroupCode { get; set; }

        // Selected mall during creation flow
        public int? MallId { get; set; }

        // Restaurants selected during creation flow
        public List<int> SelectedRestaurantIds { get; set; } = new();

        // Optional: when user is ordering within a group, you can lock them to a restaurant
        public int? CurrentRestaurantId { get; set; }

        public bool HasActiveGroup => GroupOrderId.HasValue && !string.IsNullOrWhiteSpace(GroupCode);

        public void Clear()
        {
            GroupOrderId = null;
            GroupCode = null;
            MallId = null;
            CurrentRestaurantId = null;
            SelectedRestaurantIds.Clear();
        }
    }
}
