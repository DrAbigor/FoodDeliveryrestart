using FoodDeliveryrestart.Data;
using Microsoft.AspNetCore.Identity;

namespace FoodDeliveryrestart.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<FoodDeliveryrestartUser> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<FoodDeliveryrestartUser> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
