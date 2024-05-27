using AutoMapper;
using Domain.Interfaces;
using MediatR;

namespace Application.UseCases.SaleItems.Querys.Get
{
    public class GetSaleItemHandler : IRequestHandler<GetSaleItemRequest, GetSaleItemResponse>
    {
        private readonly ISaleItemRepository _saleItemRepository;
        private readonly IMapper _mapper;

        public GetSaleItemHandler(ISaleItemRepository saleItemRepository, IMapper mapper)
        {
            _saleItemRepository = saleItemRepository;
            _mapper = mapper;
        }

        public async Task<GetSaleItemResponse> Handle(GetSaleItemRequest request, CancellationToken cancellationToken)
        {
            var saleItem = await _saleItemRepository.Get(request.Id, cancellationToken);

            return _mapper.Map<GetSaleItemResponse>(saleItem);
        }
    }
}
