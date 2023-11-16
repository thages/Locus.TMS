namespace Locus.TMS.Infrastructure.Repositories.Contacts
{
    public class DriverRepository : IDriverRepository
    {
        private readonly TmsContext _context;
        private readonly IQueryable<Driver> _queriable;
        public DriverRepository(TmsContext context)
        {
            _context = context;
            _queriable = _context.Drivers.AsNoTracking();
        }

        public void Add(Driver entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Driver entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public Driver? Get(Guid id)
        {
            return _queriable.FirstOrDefault(e => e.Id == id);
        }

        public async Task<IEnumerable<Driver>> GetAll()
        {
            return await _queriable.Select(e => e).ToListAsync();
        }

        public void Save(List<Driver> entities)
        {
            _context.AddRange(entities);
            _context.SaveChanges();
        }

        public void Update(Driver entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
