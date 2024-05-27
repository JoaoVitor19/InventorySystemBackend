using AutoMapper;
using Domain.Entities;

namespace Application.UseCases.Products.Querys.Get
{
    public sealed class GetProductMapper : Profile
    {
        public GetProductMapper()
        {
            CreateMap<GetProductRequest, Product>();
            CreateMap<Product, GetProductResponse>();
        }
    }
}
