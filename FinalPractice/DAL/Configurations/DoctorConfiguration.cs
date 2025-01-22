using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations;

public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
{
    public void Configure(EntityTypeBuilder<Doctor> builder)
    {
        builder.HasOne(d=>d.Treatment).WithMany(t=>t.Doctors).HasForeignKey(d=>d.TreatmentId).OnDelete(DeleteBehavior.NoAction);
        builder.Property(d => d.Name).IsRequired().HasMaxLength(15);
        builder.Property(d => d.ImgPath).IsRequired().HasMaxLength(200);
        
    }
}
