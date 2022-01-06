using PCO.Application.DTOs;
using PCO.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PCO.Application.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDTO>> GetUsers();
        Task<UserDTO> GetById(int? id);
        Task Add(User categoryDto);
        Task Update(UserDTO categoryDto);
        Task Remove(int? id);
    }
}
