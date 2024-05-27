namespace Domain.Entities
{
    public abstract class BaseEntity : ISoftDelete
    {
        public Guid Id { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset DateUpdated { get; set; }
        public DateTimeOffset DateDeleted { get; set; }
        public bool IsDeleted { get; set; }

    }
}
