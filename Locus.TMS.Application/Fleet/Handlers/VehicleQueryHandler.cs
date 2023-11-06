using Locus.TMS.Application.Common.Handlers;
using Locus.TMS.Application.Fleet.Mappers;
using Locus.TMS.Application.Fleet.Queries;
using Locus.TMS.Domain.DataTransferObjects.Fleet;
using Locus.TMS.Domain.Fleet.Repositories;

namespace Locus.TMS.Application.Fleet.Handlers
{
    public class VehicleQueryHandler : IApplicationQueryHandler<ListAllVehiclesQuery, IEnumerable<VehicleItem>>
    {
        private readonly IVehicleRepository _repository;
        private readonly VehicleMapper _mapper;

        public VehicleQueryHandler(IVehicleRepository repository, VehicleMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<VehicleItem>> Handle(ListAllVehiclesQuery query, CancellationToken cancellationToken)
        {
            var vehicles = await _repository.GetAll();

            IEnumerable<VehicleItem> result = Enumerable.Empty<VehicleItem>();

            if (vehicles != null)
                result = _mapper.Map(vehicles);

            return await Task.FromResult(result);

        }
    }
}
