using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTOs.Doctor;

public class CreateDocDTO
{
    public string Name { get; set; }
    public string ImgPath { get; set; }
    public int TreatmentId { get; set; }
}
