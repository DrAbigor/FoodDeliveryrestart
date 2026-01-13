using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FoodDeliveryrestart.Data;

namespace FoodDeliveryrestart.Data
{
    public class IdentityContext(DbContextOptions<IdentityContext> options) : IdentityDbContext<FoodDeliveryrestartUser>(options)
    {
    }
}
