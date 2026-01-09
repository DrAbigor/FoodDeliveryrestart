using FoodDeliveryrestart.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodDeliveryrestart.Configurations.Entities
{
    public class Mallseed : IEntityTypeConfiguration<Mall>
    {
        public void Configure(EntityTypeBuilder<Mall> builder)
        {
           builder.HasData(
           new Mall
            {
                Id = 1,
                MallName = "Tampines Mall",
                Address = "4 Tampines Central 5, Singapore 529510",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "Seed",
                UpdatedBy = "Seed"
            },
            new Mall
            {
                Id = 2,
                MallName = "Vivo City",
                Address = "1 HarbourFront Walk, Singapore 098585",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "Seed",
                UpdatedBy = "Seed"
            },
            new Mall
            {
                Id = 3,
                MallName = "Orchard Central",
                Address = "181 Orchard Rd, Singapore 238896",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "Seed",
                UpdatedBy = "Seed"
            }          
           );
        }
    }
}
