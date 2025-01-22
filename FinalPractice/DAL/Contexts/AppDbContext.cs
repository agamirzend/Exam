using DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAL.Contexts;

public class AppDbContext : IdentityDbContext
{
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Treatment> Treatments { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
}
