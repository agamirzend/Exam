using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<AppUser>
{
    public void Configure(EntityTypeBuilder<AppUser> builder)
    {
        builder.Property(u=>u.UserName).IsRequired().HasMaxLength(20);
        builder.Property(u=>u.Password).IsRequired().HasMaxLength(20);
    }
}
