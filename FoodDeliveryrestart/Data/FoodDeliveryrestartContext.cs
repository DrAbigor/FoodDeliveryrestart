using FoodDeliveryrestart.Configurations.Entities;
using FoodDeliveryrestart.Data;
using FoodDeliveryrestart.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryrestart.Data
{
    public class FoodDeliveryrestartContext(DbContextOptions<FoodDeliveryrestartContext> options) : IdentityDbContext<FoodDeliveryrestartUser>(options)
    {
        public DbSet<FoodDeliveryrestart.Domain.User> User { get; set; } = default!;
        public DbSet<FoodDeliveryrestart.Domain.Restaurant> Restaurant { get; set; } = default!;
        public DbSet<FoodDeliveryrestart.Domain.OrderItem> OrderItem { get; set; } = default!;
        public DbSet<FoodDeliveryrestart.Domain.Order> Order { get; set; } = default!;
        public DbSet<FoodDeliveryrestart.Domain.MenuItem> MenuItem { get; set; } = default!;
        public DbSet<FoodDeliveryrestart.Domain.Mall> Mall { get; set; } = default!;
        public DbSet<FoodDeliveryrestart.Domain.GroupOrderMember> GroupOrderMember { get; set; } = default!;
        public DbSet<FoodDeliveryrestart.Domain.GroupOrder> GroupOrder { get; set; } = default!;
        public DbSet<FoodDeliveryrestart.Domain.Address> Address { get; set; } = default!;
        public DbSet<FoodDeliveryrestart.Domain.Payment> Payment { get; set; } = default!;
        public DbSet<FoodDeliveryrestart.Domain.PaymentMethod> PaymentMethod { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfiguration(new PaymentMethodSeed());
            modelBuilder.ApplyConfiguration(new Mallseed());
            modelBuilder.ApplyConfiguration(new RestaurantSeed());
            modelBuilder.ApplyConfiguration(new UserSeed());

            // FIX: multiple cascade paths (User -> GroupOrderMember)
            modelBuilder.Entity<GroupOrderMember>()
                .HasOne(gom => gom.User)
                .WithMany(u => u.GroupOrderMembers)
                .HasForeignKey(gom => gom.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Payment>()
            //   .HasOne(p => p.PaymentMethods)
            //   .WithMany(pm => pm.Payments)
            //   .HasForeignKey(p => p.PaymentMethodId)
            //   .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Payment>()
               .HasOne(p => p.PaymentMethods)
               .WithMany()
               .HasForeignKey(p => p.PaymentMethodId)
               .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<PaymentMethod>()
            //   .HasOne(pm => pm.User)
            //   .WithMany(u => u.PaymentMethods)
            //   .HasForeignKey(pm => pm.UserId)
            //   .OnDelete(DeleteBehavior.Restrict);



        }
    }
}
