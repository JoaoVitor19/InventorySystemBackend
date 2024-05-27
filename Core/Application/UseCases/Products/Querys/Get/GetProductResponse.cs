namespace Application.UseCases.Products.Querys.Get
{
    public sealed record GetProductResponse
    {
        public Guid Id { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset? DateUpdated { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal InitialPrice { get; set; }
        public decimal FinalPrice { get; set; }
        public string ImagePath { get; set; }
        public int StockQuantity { get; set; }
    }
}
