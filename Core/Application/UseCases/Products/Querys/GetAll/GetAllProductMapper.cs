using AutoMapper;
using Domain.Entities;

namespace Application.UseCases.Products.Querys.GetAll;

public sealed class GetAllProductMapper : Profile
{
    public GetAllProductMapper()
    {
        CreateMap<Product, GetAllProductResponse>();
    }
}