namespace Locus.TMS.Infrastructure.Repositories.Contacts
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly TmsContext _context;
        private readonly IQueryable<Customer> _queriable;
        public CustomerRepository(TmsContext context)
        {
            _context = context;
            _queriable = _context.Customers.AsNoTracking();
        }
        public void Add(Customer entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Customer entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public Customer? Get(Guid id)
        {
            return _queriable.FirstOrDefault(e => e.Id == id);
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await _queriable.Select(e => e).ToListAsync();
        }

        public void Save(List<Customer> entities)
        {
            _context.AddRange(entities);
            _context.SaveChanges();
        }

        public void Update(Customer entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
