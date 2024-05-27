using Domain.Enums;

namespace Domain.Entities
{
    public sealed class Sale : BaseEntity
    {
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
