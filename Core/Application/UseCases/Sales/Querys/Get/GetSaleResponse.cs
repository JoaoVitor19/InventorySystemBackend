using Domain.Entities;
using Domain.Enums;

namespace Application.UseCases.Sales.Querys.Get
{
    public sealed record GetSaleResponse
    {
        public Guid Id { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset? DateUpdated { get; set; }
        public decimal Discount { get; set; }
        public int? TableNumber { get; set; }
        public string CustomerName { get; set; } = null;
        public string CustomerEmail { get; set; } = null;
        public PaymentType PaymentType { get; set; }
        public DateTimeOffset SaleDate { get; set; }
        public ICollection<SaleItem> SaleItems { get; set; }
        public decimal TotalSalePrice { get; set; }
    }
}
