namespace Domain.Interfaces
{
    public interface ISoftDelete
    {
        public DateTimeOffset? DateDeleted { get; set; }
        public bool IsDeleted { get; set; }
    }
}
