using AutoMapper;
using Domain.Entities;

namespace Application.UseCases.Sales.Commands.Update;
public sealed class UpdateSaleMapper : Profile
{
    public UpdateSaleMapper()
    {
        CreateMap<UpdateSaleRequest, Sale>();
        CreateMap<Sale, UpdateSaleResponse>();
    }
}