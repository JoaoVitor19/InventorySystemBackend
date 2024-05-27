using AutoMapper;
using Domain.Entities;

namespace Application.UseCases.Products.Commands.Update;
public sealed class UpdateProductMapper : Profile
{
    public UpdateProductMapper()
    {
        CreateMap<UpdateProductRequest, Product>();
        CreateMap<Product, UpdateProductResponse>();
    }
}