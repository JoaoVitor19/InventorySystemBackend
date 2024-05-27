using Application.UseCases.Products.Commands.Create;
using Application.UseCases.Products.Commands.Delete;
using Application.UseCases.Products.Commands.Update;
using Application.UseCases.Products.Querys.Get;
using Application.UseCases.Products.Querys.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    IMediator _mediator;
    public ProductsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("GetAll")]
    public async Task<ActionResult<List<GetAllProductResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllProductRequest(), cancellationToken);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<List<GetProductResponse>>> Get(Guid id, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetProductRequest(id), cancellationToken);
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateProductRequest request)
    {
        var ProductId = await _mediator.Send(request);
        return Ok(ProductId);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<UpdateProductResponse>> Update(Guid id, UpdateProductRequest request, CancellationToken cancellationToken)
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

        var deleteProductRequest = new DeleteProductRequest(id.Value);

        var response = await _mediator.Send(deleteProductRequest, cancellationToken);
        return Ok(response);
    }
}