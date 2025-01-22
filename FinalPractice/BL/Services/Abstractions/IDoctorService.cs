using BL.DTOs.Doctor;

namespace BL.Services.Abstractions;

public interface IDoctorService
{
    Task CreateAsync(CreateDocDTO docDTO);
    Task UpdateAsync(CreateDocDTO docDTO, int id);
    Task DeleteAsync( GetDocDTO getDoc , int id);
    Task<IEnumerable<GetDocDTO>> GetAllAsync();
    Task<GetDocDTO> GetByIdAsync(int id);
}
