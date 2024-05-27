using Domain.Interfaces;
using AutoMapper;
using MediatR;
using Domain.Entities;

namespace Application.UseCases.Sales.Commands.Update;

public class UpdateSaleHandler : IRequestHandler<UpdateSaleRequest, UpdateSaleResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ISaleRepository _saleRepository;
    private readonly IMapper _mapper;

    public UpdateSaleHandler(IUnitOfWork unitOfWork,
                             ISaleRepository saleRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _saleRepository = saleRepository;
        _mapper = mapper;
    }
    public async Task<UpdateSaleResponse> Handle(UpdateSaleRequest command, CancellationToken cancellationToken)
    {
        Sale sale = await _saleRepository.Get(command.Id, cancellationToken);

        if (sale is null) return default;

        sale.Discount = command.Discount;
        sale.TableNumber = command.TableNumber;
        sale.CustomerName = command.CustomerName;
        sale.CustomerEmail = command.CustomerEmail;
        sale.PaymentType = command.PaymentType;
        sale.SaleItems = command.SaleItems;
        sale.TotalSalePrice = command.SaleItems.Sum(x => x.TotalPrice);

        _saleRepository.Update(sale);

        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<UpdateSaleResponse>(sale);
    }
}