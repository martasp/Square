using Square.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Square.Infrastructure.Persistence.Configurations
{
    public class PointConfiguration : IEntityTypeConfiguration<Point>
    {
        public void Configure(EntityTypeBuilder<Point> builder)
        {
            builder.Property(t => t.X)
                .IsRequired();

            builder.Property(t => t.Y)
                .IsRequired();
        }
    }
}