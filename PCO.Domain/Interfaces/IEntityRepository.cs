using System.Collections.Generic;
using System.Threading.Tasks;

namespace PCO.Domain.Interfaces
{
    public interface IEntityRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int? id);
        Task<T> CreateAsync(T category);
        Task<T> UpdateAsync(T category);
        Task<T> RemoveAsync(T category);
    }
}
