namespace FoodDeliveryrestart.Domain
{
    public class GroupOrderRestaurant
    {
        public int GroupOrderId { get; set; }
        public GroupOrder? GroupOrder { get; set; }

        public int RestaurantId { get; set; }
        public Restaurant? Restaurant { get; set; }
    }
}