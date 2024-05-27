using AutoMapper;
using Domain.Interfaces;
using MediatR;

namespace Application.UseCases.Sales.Querys.Get
{
    public class GetSaleHandler : IRequestHandler<GetSaleRequest, GetSaleResponse>
    {
        private readonly ISaleRepository _saleRepository;
        private readonly IMapper _mapper;

        public GetSaleHandler(ISaleRepository saleRepository, IMapper mapper)
        {
            _saleRepository = saleRepository;
            _mapper = mapper;
        }

        public async Task<GetSaleResponse> Handle(GetSaleRequest request, CancellationToken cancellationToken)
        {
            var sale = await _saleRepository.Get(request.Id, cancellationToken);

            return _mapper.Map<GetSaleResponse>(sale);
        }
    }
}
