using Domain.Entities;

namespace Application.UseCases.SaleItems.Commands.Create
{
    public sealed record CreateSaleItemResponse
    {
        public Guid Id { get; set; }
        public Sale Sale { get; set; }
        public Guid SaleId { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public int QuantitySold { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset? DateUpdated { get; set; }
    }
}
