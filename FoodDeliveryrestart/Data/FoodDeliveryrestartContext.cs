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
        public DbSet<GroupOrderRestaurant> GroupOrderRestaurant { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Identity seed/configuration
            modelBuilder.ApplyConfiguration(new RoleSeed());
            modelBuilder.ApplyConfiguration(new UserSeed());

            // Domain seeds
            modelBuilder.ApplyConfiguration(new DomainUserSeed());
            modelBuilder.ApplyConfiguration(new PaymentMethodSeed());
            modelBuilder.ApplyConfiguration(new Mallseed());
            modelBuilder.ApplyConfiguration(new RestaurantSeed());
            modelBuilder.ApplyConfiguration(new MenuItemSeed());

            // ============================
            // GroupOrderRestaurant (JOIN)
            // ============================
            modelBuilder.Entity<GroupOrderRestaurant>()
                .HasKey(x => new { x.GroupOrderId, x.RestaurantId });

            modelBuilder.Entity<GroupOrderRestaurant>()
                .HasOne(x => x.GroupOrder)
                .WithMany()
                .HasForeignKey(x => x.GroupOrderId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<GroupOrderRestaurant>()
                .HasOne(x => x.Restaurant)
                .WithMany()
                .HasForeignKey(x => x.RestaurantId)
                .OnDelete(DeleteBehavior.Cascade);

            // ==========================================
            // FIX: multiple cascade paths (SQL Server)
            // ==========================================

            // User -> GroupOrderMember
            modelBuilder.Entity<GroupOrderMember>()
                .HasOne(gom => gom.User)
                .WithMany(u => u.GroupOrderMembers)
                .HasForeignKey(gom => gom.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            // GroupOrder -> GroupOrderMember
            modelBuilder.Entity<GroupOrderMember>()
                .HasOne(gom => gom.GroupOrder)
                .WithMany(go => go.GroupOrderMembers)
                .HasForeignKey(gom => gom.GroupOrderId)
                .OnDelete(DeleteBehavior.NoAction);

            // Order -> User
            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Payment -> PaymentMethod
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.PaymentMethod)
                .WithMany(pm => pm.Payments)
                .HasForeignKey(p => p.PaymentMethodId)
                .OnDelete(DeleteBehavior.Restrict);

            // ============================
            // Decimal precision (fix warnings + prevent truncation)
            // ============================
            modelBuilder.Entity<MenuItem>()
                .Property(x => x.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Order>()
                .Property(x => x.TotalAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OrderItem>()
                .Property(x => x.ItemPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<OrderItem>()
                .Property(x => x.Subtotal)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Payment>()
                .Property(x => x.Amount)
                .HasPrecision(10, 2);

            // Rating: 0.0 to 5.0 (one decimal place, e.g. 4.6)
            modelBuilder.Entity<Restaurant>()
                .Property(x => x.Rating)
                .HasPrecision(2, 1);
        }
    }
}
