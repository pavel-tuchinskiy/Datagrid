using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Data.Configuration
{
    internal class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasOne(x => x.User)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.UserId);

            builder.Property(x => x.OrderDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()");

            builder.Property(x => x.Status)
                .HasDefaultValue(OrderStatus.Awaiting);

            builder.Property(x => x.TotalPrice)
                .HasColumnType("decimal(18, 2)");

            builder.HasCheckConstraint("CK_OrdersAndProducts_TotalPrice", "[TotalPrice] > 0");
        }
    }
}
