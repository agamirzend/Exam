using AutoMapper;
using BL.DTOs.Doctor;
using DAL.Models;

namespace BL.Profiles;

public class DoctorProfile : Profile
{
    public DoctorProfile()
    {
        CreateMap<Doctor, CreateDocDTO>().ReverseMap();
        CreateMap<Doctor, GetDocDTO>().ReverseMap();
    }
}
