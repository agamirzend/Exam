using AutoMapper;
using BL.DTOs.Doctor;
using BL.Services.Abstractions;
using DAL.Models;
using DAL.Repositories;

namespace BL.Services.Concretes;

public class DoctorService : IDoctorService
{
    private readonly IRepository<Doctor> _repository;
    private readonly IMapper _mapper;

    public DoctorService(IMapper mapper, IRepository<Doctor> repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task CreateAsync(CreateDocDTO docDTO)
    {
         Doctor doctor = _mapper.Map<Doctor>(docDTO);
         await _repository.CreateAsync(doctor);
        int rows = await _repository.SaveChangeAsync();
        if (rows == 0)
        {
            throw new Exception("Something went wrong");
        }
    }

    public Task DeleteAsync(GetDocDTO getDoc, int id)
    {
        Doctor doctor = _mapper.Map<Doctor>(getDoc);
        _repository.Delete(doctor);
    }

    public async Task<IEnumerable<GetDocDTO>> GetAllAsync()
    {
        IEnumerable<Doctor> doctors = await _repository.GetAllAsync();
        IEnumerable<GetDocDTO> getDocs = _mapper.Map<GetDocDTO>(doctors);
        return getDocs;
    }

    public async Task<GetDocDTO> GetByIdAsync(int id)
    {
        Doctor doctor = await _repository.GetByIdAsync(id);
        GetDocDTO getDoc = _mapper.Map<GetDocDTO>(doctor);
        return getDoc;
    }

    public Task UpdateAsync(CreateDocDTO docDTO, int id)
    {
        throw new NotImplementedException();
    }
}   