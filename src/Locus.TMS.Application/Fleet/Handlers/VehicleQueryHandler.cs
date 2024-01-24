using Locus.TMS.Application.Common.Handlers;
using Locus.TMS.Application.Fleet.Mappers;
using Locus.TMS.Application.Fleet.Queries;
using Locus.TMS.Domain.Fleet.DataTransferObjects;
using Locus.TMS.Domain.Fleet.Repositories;

namespace Locus.TMS.Application.Fleet.Handlers
{
    public class VehicleQueryHandler 
        : IApplicationQueryHandler<ListAllVehiclesQuery, IEnumerable<VehicleItem>>
        , IApplicationQueryHandler<ListFleetQuery, IEnumerable<FleetItem>>
    {
        private readonly IVehicleRepository _repository;
        private readonly VehicleMapper _mapper;
        private readonly FleetMapper _fleetMapper;

        public VehicleQueryHandler(IVehicleRepository repository, VehicleMapper mapper, FleetMapper fleetMapper)
        {
            _repository = repository;
            _mapper = mapper;
            _fleetMapper = fleetMapper;
        }

        public async Task<IEnumerable<VehicleItem>> Handle(ListAllVehiclesQuery query, CancellationToken cancellationToken)
        {
            var vehicles = await _repository.GetAll();

            IEnumerable<VehicleItem> result = Enumerable.Empty<VehicleItem>();

            if (vehicles != null)
                result = _mapper.Map(vehicles);

            return await Task.FromResult(result);
        }

        public async Task<IEnumerable<FleetItem>> Handle(ListFleetQuery query, CancellationToken cancellationToken)
        {
            var fleet = await _repository.GetAll();

            IEnumerable<FleetItem> result = Enumerable.Empty<FleetItem>();

            if (fleet != null)
                result = _fleetMapper.Map(fleet);

            return await Task.FromResult(result);
        }
    }
}
