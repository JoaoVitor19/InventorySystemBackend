using AutoMapper;
using Domain.Entities;

namespace Application.UseCases.SaleItems.Querys.Get
{
    public sealed class GetSaleItemMapper : Profile
    {
        public GetSaleItemMapper()
        {
            CreateMap<GetSaleItemRequest, SaleItem>();
            CreateMap<SaleItem, GetSaleItemResponse>();
        }
    }
}
