namespace Domain.Entities
{
    public class SaleItem : BaseEntity
    {
        public Sale Sale { get; set; }
        public Guid SaleId { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public int QuantitySold { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
