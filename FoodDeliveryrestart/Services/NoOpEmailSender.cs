using Microsoft.AspNetCore.Identity;

namespace FoodDeliveryrestart.Services;

public class NoOpEmailSender : IEmailSender<FoodDeliveryrestart.Data.FoodDeliveryrestartUser>
{
    public Task SendConfirmationLinkAsync(FoodDeliveryrestart.Data.FoodDeliveryrestartUser user, string email, string confirmationLink)
    {
        // No-op: doesn't actually send emails
        return Task.CompletedTask;
    }

    public Task SendPasswordResetLinkAsync(FoodDeliveryrestart.Data.FoodDeliveryrestartUser user, string email, string resetLink)
    {
        // No-op: doesn't actually send emails
        return Task.CompletedTask;
    }

    public Task SendPasswordResetCodeAsync(FoodDeliveryrestart.Data.FoodDeliveryrestartUser user, string email, string resetCode)
    {
        // No-op: doesn't actually send emails
        return Task.CompletedTask;
    }
}