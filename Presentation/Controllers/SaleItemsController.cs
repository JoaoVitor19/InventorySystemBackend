using Application.UseCases.SaleItems.Commands.Create;
using Application.UseCases.SaleItems.Commands.Delete;
using Application.UseCases.SaleItems.Commands.Update;
using Application.UseCases.SaleItems.Querys.Get;
using Application.UseCases.SaleItems.Querys.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SaleItemsController : ControllerBase
{
    IMediator _mediator;
    public SaleItemsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("GetAll")]
    public async Task<ActionResult<List<GetAllSaleItemResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllSaleItemRequest(), cancellationToken);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<List<GetSaleItemResponse>>> Get(Guid id, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetSaleItemRequest(id), cancellationToken);
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateSaleItemRequest request)
    {
        var saleItemId = await _mediator.Send(request);
        return Ok(saleItemId);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<UpdateSaleItemResponse>> Update(Guid id, UpdateSaleItemRequest request, CancellationToken cancellationToken)
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

        var deleteSaleItemRequest = new DeleteSaleItemRequest(id.Value);

        var response = await _mediator.Send(deleteSaleItemRequest, cancellationToken);
        return Ok(response);
    }
}