using AutoMapper;
using PCO.Application.DTOs;
using PCO.Application.Interfaces;
using PCO.Domain.Entities;
using PCO.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PCO.Application.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository repo, IMapper mapper)
        {
            _userRepository = repo;
            _mapper = mapper;
        }

        public async Task Add(User userDto)
        {
            await _userRepository.CreateAsync(userDto);
        }

        public async Task<UserDTO> GetById(int? id)
        {
            var userEntity = await _userRepository.GetByIdAsync(id);
            return _mapper.Map<UserDTO>(userEntity);
        }

        public async Task<IEnumerable<UserDTO>> GetUsers()
        {
            var usersEntity = await _userRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<UserDTO>>(usersEntity);
        }

        public async Task Remove(int? id)
        {
            var userEntity = _userRepository.GetByIdAsync(id).Result;
            await _userRepository.RemoveAsync(userEntity);
        }

        public async Task Update(UserDTO userDto)
        {
            var userEntity = _mapper.Map<User>(userDto);
            await _userRepository.UpdateAsync(userEntity);
        }
    }
}
