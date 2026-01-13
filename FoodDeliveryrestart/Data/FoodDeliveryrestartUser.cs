using Microsoft.AspNetCore.Identity;

namespace FoodDeliveryrestart.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class FoodDeliveryrestartUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
