using DAL.Models.Base;

namespace DAL.Models;

public class Treatment : BaseAuditableEntity
{
    public string Name { get; set; }
    public string Description {  get; set; } 
    public ICollection<Doctor> Doctors { get; set; }
}