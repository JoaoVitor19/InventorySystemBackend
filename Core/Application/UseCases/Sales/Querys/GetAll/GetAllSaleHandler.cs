using AutoMapper;
using Domain.Interfaces;
using MediatR;

namespace Application.UseCases.Sales.Querys.GetAll;

public sealed class GetAllSaleHandler : IRequestHandler<GetAllSaleRequest, List<GetAllSaleResponse>>
{
    private readonly ISaleRepository _saleRepository;
    private readonly IMapper _mapper;

    public GetAllSaleHandler(ISaleRepository saleRepository, IMapper mapper)
    {
        _saleRepository = saleRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllSaleResponse>> Handle(GetAllSaleRequest request, CancellationToken cancellationToken)
    {
        var sales = await _saleRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllSaleResponse>>(sales);
    }
}