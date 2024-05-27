using Domain.Interfaces;
using AutoMapper;
using MediatR;
using Domain.Entities;

namespace Application.UseCases.SaleItems.Commands.Update;

public class UpdateSaleItemHandler : IRequestHandler<UpdateSaleItemRequest, UpdateSaleItemResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ISaleItemRepository _saleItemRepository;
    private readonly IMapper _mapper;

    public UpdateSaleItemHandler(IUnitOfWork unitOfWork,
                             ISaleItemRepository saleItemRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _saleItemRepository = saleItemRepository;
        _mapper = mapper;
    }
    public async Task<UpdateSaleItemResponse> Handle(UpdateSaleItemRequest command, CancellationToken cancellationToken)
    {
        SaleItem saleItem = await _saleItemRepository.Get(command.Id, cancellationToken);

        if (saleItem is null) return default;

        saleItem.ProductId = command.ProductId;
        saleItem.SaleId = command.SaleId;
        saleItem.Price = command.Price;
        saleItem.QuantitySold = command.QuantitySold;

        saleItem.GetTotalPrice();

        _saleItemRepository.Update(saleItem);

        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<UpdateSaleItemResponse>(saleItem);
    }
}