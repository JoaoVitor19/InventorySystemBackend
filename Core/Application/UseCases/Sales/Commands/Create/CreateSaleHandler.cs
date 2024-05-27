using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using MediatR;

namespace Application.UseCases.Sales.Commands.Create
{
    public class CreateSaleHandler : IRequestHandler<CreateSaleRequest, CreateSaleResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISaleRepository _saleRepository;
        private readonly IMapper _mapper;

        public CreateSaleHandler(IUnitOfWork unitOfWork, ISaleRepository saleRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _saleRepository = saleRepository;
            _mapper = mapper;
        }

        public async Task<CreateSaleResponse> Handle(CreateSaleRequest request, CancellationToken cancellationToken)
        {
            var sale = _mapper.Map<Sale>(request);

            _saleRepository.Create(sale);

            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<CreateSaleResponse>(sale);
        }
    }
}
