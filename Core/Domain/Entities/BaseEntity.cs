namespace Domain.Entities
{
    public abstract class BaseEntity : ISoftDelete
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateDeleted { get; set; }
        public bool IsDeleted { get; set; }

    }
}
