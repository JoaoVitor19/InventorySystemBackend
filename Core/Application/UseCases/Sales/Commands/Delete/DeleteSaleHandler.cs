using AutoMapper;
using Domain.Interfaces;
using MediatR;

namespace Application.UseCases.Sales.Commands.Delete;

public sealed class DeleteSaleHandler :
                    IRequestHandler<DeleteSaleRequest, DeleteSaleResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ISaleRepository _saleRepository;
    private readonly IMapper _mapper;

    public DeleteSaleHandler(IUnitOfWork unitOfWork,
                             ISaleRepository saleRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _saleRepository = saleRepository;
        _mapper = mapper;
    }

    public async Task<DeleteSaleResponse> Handle(DeleteSaleRequest request,
                                                 CancellationToken cancellationToken)
    {

        var sale = await _saleRepository.Get(request.Id, cancellationToken);

        if (sale == null) return default;

        _saleRepository.Delete(sale);

        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<DeleteSaleResponse>(sale);
    }
}