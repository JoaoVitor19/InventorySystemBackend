using AutoMapper;
using Domain.Entities;

namespace Application.UseCases.Sales.Querys.GetAll;

public sealed class GetAllSaleMapper : Profile
{
    public GetAllSaleMapper()
    {
        CreateMap<Sale, GetAllSaleResponse>();
    }
}