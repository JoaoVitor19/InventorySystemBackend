namespace Domain.Entities
{
    public interface ISoftDelete
    {
        public DateTimeOffset DateDeleted { get; set; }
        public bool IsDeleted { get; set; }
    }
}
