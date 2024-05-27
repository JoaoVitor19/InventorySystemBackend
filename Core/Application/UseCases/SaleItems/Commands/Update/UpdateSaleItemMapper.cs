using AutoMapper;
using Domain.Entities;

namespace Application.UseCases.SaleItems.Commands.Update;
public sealed class UpdateSaleItemMapper : Profile
{
    public UpdateSaleItemMapper()
    {
        CreateMap<UpdateSaleItemRequest, SaleItem>();
        CreateMap<SaleItem, UpdateSaleItemResponse>();
    }
}