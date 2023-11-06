namespace Locus.TMS.Infrastructure.Repositories.Fleet
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly TmsContext _context;
        private readonly IQueryable<Vehicle> _queriable;
        public VehicleRepository(TmsContext context)
        {
            _context = context;
            _queriable = _context.Vehicles.AsNoTracking();
        }

        public void Add(Vehicle entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Vehicle entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public Vehicle? Get(Guid id)
        {
            return _queriable.FirstOrDefault(e => e.Id == id);
        }

        public async Task<IEnumerable<Vehicle>> GetAll()
        {
            return await _queriable.Select(e => e).ToListAsync();
        }

        public void Save(List<Vehicle> entities)
        {
            _context.AddRange(entities);
            _context.SaveChanges();
        }

        public void Update(Vehicle entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}

