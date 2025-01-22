using Microsoft.EntityFrameworkCore;

namespace DAL.Contexts;

public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
}
