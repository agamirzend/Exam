using AutoMapper;
using BL.DTOs.Treatment;
using DAL.Models;

namespace BL.Profiles;

public class TreatmentProfile : Profile
{
    public TreatmentProfile()
    {
        CreateMap<Treatment,CreateTreatmentDTO>().ReverseMap();
        CreateMap<Treatment,GetTreatmentDTO>().ReverseMap();
    }
}
