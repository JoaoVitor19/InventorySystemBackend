using AutoMapper;
using Domain.Interfaces;
using MediatR;

namespace Application.UseCases.SaleItems.Commands.Delete;

public sealed class DeleteSaleItemHandler :
                    IRequestHandler<DeleteSaleItemRequest, DeleteSaleItemResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ISaleItemRepository _saleItemRepository;
    private readonly IMapper _mapper;

    public DeleteSaleItemHandler(IUnitOfWork unitOfWork,
                             ISaleItemRepository saleItemRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _saleItemRepository = saleItemRepository;
        _mapper = mapper;
    }

    public async Task<DeleteSaleItemResponse> Handle(DeleteSaleItemRequest request,
                                                 CancellationToken cancellationToken)
    {

        var saleItem = await _saleItemRepository.Get(request.Id, cancellationToken);

        if (saleItem == null) return default;

        _saleItemRepository.Delete(saleItem);

        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<DeleteSaleItemResponse>(saleItem);
    }
}