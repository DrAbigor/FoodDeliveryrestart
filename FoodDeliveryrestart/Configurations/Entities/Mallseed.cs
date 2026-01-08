using FoodDeliveryrestart.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodDeliveryrestart.Configurations.Entities
{
    public class Mallseed : IEntityTypeConfiguration<Mall>
    {
        public void Configure(EntityTypeBuilder<Mall> builder)
        {
            new Mall
            {
                Id = 1,
                MallName = "Tampines Mall",
                Address = "4 Tampines Central 5, Singapore 529510",
            };
            new Mall
            {
                Id = 2,
                MallName = "Vivo City",
                Address = "1 HarbourFront Walk, Singapore 098585",
            };
            new Mall
            {
                Id = 3,
                MallName = "Orchard Central",
                Address = "181 Orchard Rd, Singapore 238896"
            };
        }
    }
}
