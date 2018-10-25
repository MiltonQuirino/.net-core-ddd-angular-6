using System;
using Airplane.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Airplane.Infra.Data.Mapping
{
    public class PlaneMap: IEntityTypeConfiguration<Plane>
    {
        public void Configure(EntityTypeBuilder<Plane> builder)
        {
            builder.ToTable("Airplane");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Model)
                   .IsRequired()
                   .HasColumnName("Model");

            builder.Property(x => x.Capacity)
                   .HasColumnName("Capacity");

            builder.Property(x => x.CreatedAt)
                   .HasColumnName("CreateadAt");
                   
        }
    }
}
