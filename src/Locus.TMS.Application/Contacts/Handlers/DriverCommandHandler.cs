using Locus.TMS.Application.Common.Handlers;
using Locus.TMS.Application.Contacts.Commands;
using Locus.TMS.Application.Contacts.Mappers;
using Locus.TMS.Domain.Contacts.DataTransferObjects;
using Locus.TMS.Domain.Contacts.Repositories;

namespace Locus.TMS.Application.Contacts.Handlers
{
    public class DriverCommandHandler : IApplicationCommandHandler<CreateDriverCommand, DriverItem>
    {
        private readonly DriverMapper _mapper;
        private readonly IDriverRepository _repository;

        public DriverCommandHandler(DriverMapper mapper, IDriverRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public Task<DriverItem> Handle(CreateDriverCommand command, CancellationToken cancellationToken)
        {
            var driver = _mapper.Map(command);
            _repository.Add(driver);

            DriverItem response = _mapper.Map(driver);

            return Task.FromResult(response);
        }
    }
}
