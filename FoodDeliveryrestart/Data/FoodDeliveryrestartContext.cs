using FoodDeliveryrestart.Configurations.Entities;
using FoodDeliveryrestart.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryrestart.Data
{
    public class FoodDeliveryrestartContext : IdentityDbContext<FoodDeliveryrestartUser>
    {
        public FoodDeliveryrestartContext(DbContextOptions<FoodDeliveryrestartContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; } = default!;
        public DbSet<Restaurant> Restaurant { get; set; } = default!;
        public DbSet<OrderItem> OrderItem { get; set; } = default!;
        public DbSet<Order> Order { get; set; } = default!;
        public DbSet<MenuItem> MenuItem { get; set; } = default!;
        public DbSet<Mall> Mall { get; set; } = default!;
        public DbSet<GroupOrderMember> GroupOrderMember { get; set; } = default!;
        public DbSet<GroupOrder> GroupOrder { get; set; } = default!;
        public DbSet<Address> Address { get; set; } = default!;
        public DbSet<Payment> Payment { get; set; } = default!;
        public DbSet<PaymentMethod> PaymentMethod { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Identity seed/configuration
            modelBuilder.ApplyConfiguration(new RoleSeed());
            modelBuilder.ApplyConfiguration(new UserSeed());

            // domain seeds (ensure DomainUserSeed is still applied if you need the domain User row)
            modelBuilder.ApplyConfiguration(new DomainUserSeed());
            modelBuilder.ApplyConfiguration(new PaymentMethodSeed());
            modelBuilder.ApplyConfiguration(new Mallseed());
            modelBuilder.ApplyConfiguration(new RestaurantSeed());

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

            // Single Payment -> PaymentMethod relationship (singular navigation)
            modelBuilder.Entity<Payment>()
               .HasOne(p => p.PaymentMethod)
               .WithMany(pm => pm.Payments)
               .HasForeignKey(p => p.PaymentMethodId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}