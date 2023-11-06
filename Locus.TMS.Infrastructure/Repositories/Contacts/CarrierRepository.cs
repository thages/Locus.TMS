namespace Locus.TMS.Infrastructure.Repositories.Contacts
{
    public class CarrierRepository : ICarrierRepository
    {
        private readonly TmsContext _context;
        private readonly IQueryable<Carrier> _queriable;
        public CarrierRepository(TmsContext context)
        {
            _context = context;
            _queriable = _context.Carriers.AsNoTracking();
        }
        public void Add(Carrier entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Carrier entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public Carrier? Get(Guid id)
        {
            return _queriable.FirstOrDefault(e => e.Id == id);
        }

        public async Task<IEnumerable<Carrier>> GetAll()
        {
            return await _queriable.Select(e => e).ToListAsync();
        }

        public void Save(List<Carrier> entities)
        {
            _context.AddRange(entities);
            _context.SaveChanges();
        }

        public void Update(Carrier entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
