using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations;

public class TreatmentConfiguration : IEntityTypeConfiguration<Treatment>
{
    public void Configure(EntityTypeBuilder<Treatment> builder)
    {
        builder.HasMany(t=>t.Doctors).WithOne(d => d.Treatment).HasForeignKey(d=>d.TreatmentId);
        builder.Property(t=>t.Name).IsRequired().HasMaxLength(15);
        builder.Property(t=>t.Description).IsRequired().HasMaxLength(30);
    }
}
