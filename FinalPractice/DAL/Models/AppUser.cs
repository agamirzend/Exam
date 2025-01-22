using DAL.Models.Base;

namespace DAL.Models;

public class AppUser : BaseAuditableEntity
{
    public string UserName { get; set; }
    public string Password { get; set; }
}
