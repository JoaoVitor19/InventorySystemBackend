using AutoMapper;
using Domain.Entities;

namespace Application.UseCases.Products.Commands.Create
{
    public sealed class CreateProductMapper : Profile
    {
        public CreateProductMapper()
        {
            CreateMap<CreateProductRequest, Product>();
            CreateMap<Product, CreateProductResponse>();
        }
    }
}
