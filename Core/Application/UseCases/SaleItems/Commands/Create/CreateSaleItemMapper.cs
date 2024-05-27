using AutoMapper;
using Domain.Entities;

namespace Application.UseCases.SaleItems.Commands.Create
{
    public sealed class CreateSaleItemMapper : Profile
    {
        public CreateSaleItemMapper()
        {
            CreateMap<CreateSaleItemRequest, SaleItem>();
            CreateMap<SaleItem, CreateSaleItemResponse>();
        }
    }
}
