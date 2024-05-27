using AutoMapper;
using Domain.Entities;

namespace Application.UseCases.Sales.Commands.Create
{
    public sealed class CreateSaleMapper : Profile
    {
        public CreateSaleMapper()
        {
            CreateMap<CreateSaleRequest, Sale>();
            CreateMap<Sale, CreateSaleResponse>();
        }
    }
}
