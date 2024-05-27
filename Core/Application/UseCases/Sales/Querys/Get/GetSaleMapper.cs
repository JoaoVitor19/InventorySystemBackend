using AutoMapper;
using Domain.Entities;

namespace Application.UseCases.Sales.Querys.Get
{
    public sealed class GetSaleMapper : Profile
    {
        public GetSaleMapper()
        {
            CreateMap<GetSaleRequest, Sale>();
            CreateMap<Sale, GetSaleResponse>();
        }
    }
}
