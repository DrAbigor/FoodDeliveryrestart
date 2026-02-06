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
        public DbSet<Voucher> Voucher { get; set; } = default!;
        public DbSet<UserVoucher> UserVoucher { get; set; } = default!;

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
                .OnDelete(DeleteBehavior.Restrict);

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

            // ============================
            // Voucher configuration
            // ============================
            modelBuilder.Entity<Voucher>()
                .Property(x => x.DiscountValue)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Voucher>()
                .Property(x => x.MinimumOrder)
                .HasPrecision(10, 2);

            modelBuilder.Entity<UserVoucher>()
                .HasOne(uv => uv.Voucher)
                .WithMany(v => v.UserVouchers)
                .HasForeignKey(uv => uv.VoucherId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserVoucher>()
                .HasOne(uv => uv.Order)
                .WithMany()
                .HasForeignKey(uv => uv.OrderId)
                .OnDelete(DeleteBehavior.SetNull);

            // Seed vouchers
            modelBuilder.Entity<Voucher>().HasData(
                new Voucher
                {
                    Id = 1,
                    Code = "SAVE20",
                    Name = "20% OFF for New Users",
                    Description = "Get 20% off your order! Perfect for first-time customers.",
                    DiscountType = "Percentage",
                    DiscountValue = 20,
                    MinimumOrder = null,
                    IsActive = true,
                    ExpiryDate = null,
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Voucher
                {
                    Id = 2,
                    Code = "FREEDELIVERY15",
                    Name = "Free Delivery For Orders Above $15!",
                    Description = "Enjoy free delivery when you order $15 or more.",
                    DiscountType = "FreeDelivery",
                    DiscountValue = 0,
                    MinimumOrder = 15,
                    IsActive = true,
                    ExpiryDate = null,
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
