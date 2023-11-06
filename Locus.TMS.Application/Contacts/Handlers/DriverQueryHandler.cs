using Locus.TMS.Application.Common.Handlers;
using Locus.TMS.Application.Contacts.Mappers;
using Locus.TMS.Application.Contacts.Queries;
using Locus.TMS.Domain.Contacts.DataTransferObjects;
using Locus.TMS.Domain.Contacts.Repositories;

namespace Locus.TMS.Application.Contacts.Handlers
{
    public class DriverQueryHandler : IApplicationQueryHandler<ListAllDriversQuery, IEnumerable<DriverItem>>
    {
        private readonly DriverMapper _mapper;
        private readonly IDriverRepository _repository;

        public DriverQueryHandler(DriverMapper mapper, IDriverRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<IEnumerable<DriverItem>> Handle(ListAllDriversQuery query, CancellationToken cancellationToken)
        {
            var drivers = await _repository.GetAll();
            IEnumerable<DriverItem> result = Enumerable.Empty<DriverItem>();

            if (drivers != null)
                result = _mapper.Map(drivers);

            return await Task.FromResult(result);
        }
    }
}
