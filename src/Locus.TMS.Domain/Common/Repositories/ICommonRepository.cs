using Locus.TMS.Domain.Common.Models;

namespace Locus.TMS.Domain.Common.Repositories
{
    public interface ICommonRepository<T>
            where T : EntityModel
    {
        void Add(T entity);
        void Save(List<T> entities);
        void Update(T entity);
        void Delete(T entity);
        T? Get(Guid id);
        Task<IEnumerable<T>> GetAll();
    }
}
