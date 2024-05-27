using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using MediatR;

namespace Application.UseCases.SaleItems.Commands.Create
{
    public class CreateSaleItemHandler : IRequestHandler<CreateSaleItemRequest, CreateSaleItemResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISaleItemRepository _saleItemRepository;
        private readonly IMapper _mapper;

        public CreateSaleItemHandler(IUnitOfWork unitOfWork, ISaleItemRepository saleItemRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _saleItemRepository = saleItemRepository;
            _mapper = mapper;
        }

        public async Task<CreateSaleItemResponse> Handle(CreateSaleItemRequest request, CancellationToken cancellationToken)
        {
            var saleItem = _mapper.Map<SaleItem>(request);

            saleItem.GetTotalPrice();

            _saleItemRepository.Create(saleItem);

            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<CreateSaleItemResponse>(saleItem);
        }
    }
}
