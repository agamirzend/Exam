using DAL.Models.Base;

namespace DAL.Models;

public class Doctor : BaseAuditableEntity
{
    public string Name { get; set; }
    public string ImgPath { get; set; }
    public Treatment Treatment { get; set; }
    public int TreatmentId { get; set; }
}
