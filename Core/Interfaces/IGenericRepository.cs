using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Specification;

namespace Infrastructure.Data
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsyn(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> GetEntityWithSpec(ISpecification<T> spec);
        Task<IReadOnlyList<T>> ListAysn(ISpecification<T> spec);

    }
}
