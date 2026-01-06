using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FoodDeliveryrestart.Domain;

namespace FoodDeliveryrestart.Data
{
    public class FoodDeliveryrestartContext : DbContext
    {
        public FoodDeliveryrestartContext (DbContextOptions<FoodDeliveryrestartContext> options)
            : base(options)
        {
        }

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

            modelBuilder.Entity<Payment>()
               .HasOne(p => p.PaymentMethods)
               .WithMany(pm => pm.Payments)
               .HasForeignKey(p => p.PaymentMethodId)
               .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Payment>()
               .HasOne(p => p.PaymentMethods)
               .WithMany()
               .HasForeignKey(p => p.PaymentMethodId)
               .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
