using Locus.TMS.Application.Common.Handlers;
using Locus.TMS.Application.Transportation.Mappers;
using Locus.TMS.Application.Transportation.Queries;
using Locus.TMS.Domain.Transportation.DataTransferObjects;
using Locus.TMS.Domain.Transportation.Repositories;

namespace Locus.TMS.Application.Transportation.Handlers
{
    public class LoadQueryHandler : IApplicationQueryHandler<ListAllLoadsQuery, IEnumerable<LoadItem>>
    {
        private readonly LoadMapper _mapper;
        private readonly ILoadRepository _repository;

        public LoadQueryHandler(LoadMapper mapper, ILoadRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<IEnumerable<LoadItem>> Handle(ListAllLoadsQuery query, CancellationToken cancellationToken)
        {
            var loads = await _repository.GetAll();
            IEnumerable<LoadItem> result = Enumerable.Empty<LoadItem>();

            if (loads != null)
                result = _mapper.Map(loads);

            return await Task.FromResult(result);
        }
    }
}
