using Locus.TMS.Domain.Transportation.Models;
using Locus.TMS.Domain.Transportation.Repositories;

namespace Locus.TMS.Infrastructure.Repositories.Transportation
{
    public class LoadRepository : ILoadRepository
    {
        private readonly TmsContext _context;
        private readonly IQueryable<Load> _queriable;
        public LoadRepository(TmsContext context)
        {
            _context = context;
            _queriable = _context.Loads.AsNoTracking();
        }
        public void Add(Load entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Load entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public Load? Get(Guid id)
        {
            return _queriable.FirstOrDefault(e => e.Id == id);
        }

        public async Task<IEnumerable<Load>> GetAll()
        {
            return await _queriable.Select(e => e).ToListAsync();
        }

        public void Save(List<Load> entities)
        {
            _context.AddRange(entities);
            _context.SaveChanges();
        }

        public void Update(Load entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
