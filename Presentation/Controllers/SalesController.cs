using Application.UseCases.Sales.Commands.Create;
using Application.UseCases.Sales.Commands.Delete;
using Application.UseCases.Sales.Commands.Update;
using Application.UseCases.Sales.Querys.Get;
using Application.UseCases.Sales.Querys.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SalesController : ControllerBase
{
    IMediator _mediator;
    public SalesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("GetAll")]
    public async Task<ActionResult<List<GetAllSaleResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllSaleRequest(), cancellationToken);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<List<GetSaleResponse>>> Get(Guid id, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetSaleRequest(id), cancellationToken);
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateSaleRequest request)
    {
        var saleId = await _mediator.Send(request);
        return Ok(saleId);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<UpdateSaleResponse>> Update(Guid id, UpdateSaleRequest request, CancellationToken cancellationToken)
    {
        if (id != request.Id)
            return BadRequest();

        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(Guid? id, CancellationToken cancellationToken)
    {
        if (id is null)
            return BadRequest();

        var deleteSaleRequest = new DeleteSaleRequest(id.Value);

        var response = await _mediator.Send(deleteSaleRequest, cancellationToken);
        return Ok(response);
    }
}