using AutoMapper;
using Domain.Interfaces;
using MediatR;

namespace Application.UseCases.SaleItems.Querys.GetAll;

public sealed class GetAllSaleItemHandler : IRequestHandler<GetAllSaleItemRequest, List<GetAllSaleItemResponse>>
{
    private readonly ISaleItemRepository _saleItemRepository;
    private readonly IMapper _mapper;

    public GetAllSaleItemHandler(ISaleItemRepository saleItemRepository, IMapper mapper)
    {
        _saleItemRepository = saleItemRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllSaleItemResponse>> Handle(GetAllSaleItemRequest request, CancellationToken cancellationToken)
    {
        var saleItems = await _saleItemRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllSaleItemResponse>>(saleItems);
    }
}