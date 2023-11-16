using Locus.TMS.Application.Commands.Fleet;
using Locus.TMS.Application.Common.Handlers;
using Locus.TMS.Application.Fleet.Mappers;
using Locus.TMS.Domain.DataTransferObjects.Fleet;
using Locus.TMS.Domain.Fleet.Repositories;

namespace Locus.TMS.Application.Fleet.Handlers
{
    public class VehicleCommandHandler : IApplicationCommandHandler<CreateVehicleCommand, VehicleItem>
    {
        private readonly IVehicleRepository _repository;
        private readonly VehicleMapper _mapper;

        public VehicleCommandHandler(IVehicleRepository repository, VehicleMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<VehicleItem> Handle(CreateVehicleCommand command, CancellationToken cancellationToken)
        {
            var vehicle = _mapper.Map(command);
            _repository.Add(vehicle);

            VehicleItem response = _mapper.Map(vehicle);

            return Task.FromResult(response);
        }
    }
}
