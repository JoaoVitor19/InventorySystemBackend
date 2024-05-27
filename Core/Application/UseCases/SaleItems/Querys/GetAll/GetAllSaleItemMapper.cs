using AutoMapper;
using Domain.Entities;

namespace Application.UseCases.SaleItems.Querys.GetAll;

public sealed class GetAllSaleItemMapper : Profile
{
    public GetAllSaleItemMapper()
    {
        CreateMap<SaleItem, GetAllSaleItemResponse>();
    }
}