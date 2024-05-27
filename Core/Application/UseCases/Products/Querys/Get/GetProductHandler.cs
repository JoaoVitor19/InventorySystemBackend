using AutoMapper;
using Domain.Interfaces;
using MediatR;

namespace Application.UseCases.Products.Querys.Get
{
    public class GetProductHandler : IRequestHandler<GetProductRequest, GetProductResponse>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<GetProductResponse> Handle(GetProductRequest request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.Get(request.Id, cancellationToken);

            return _mapper.Map<GetProductResponse>(product);
        }
    }
}
