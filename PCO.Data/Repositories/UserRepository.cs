using Microsoft.EntityFrameworkCore;
using PCO.Data.Context;
using PCO.Domain.Entities;
using PCO.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PCO.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private ApplicationDbContext _userContext;

        public UserRepository(ApplicationDbContext context)
        {
            _userContext = context;
        }

        public async Task<User> CreateAsync(User category)
        {
            _userContext.Add(category);
            await _userContext.SaveChangesAsync();
            return category;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _userContext.Users.AsNoTracking().ToListAsync();
        }

        public async Task<User> GetByIdAsync(int? id)
        {
            return await _userContext.Users.FindAsync(id);
        }

        public async Task<User> RemoveAsync(User category)
        {
            _userContext.Remove(category);
            await _userContext.SaveChangesAsync();
            return category;
        }

        public async Task<User> UpdateAsync(User category)
        {
            _userContext.Update(category);
            await _userContext.SaveChangesAsync();
            return category;
        }
    }
}
