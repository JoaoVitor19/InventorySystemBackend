namespace Domain.Entities
{
    public interface ISoftDelete
    {
        public DateTime? DateDeleted { get; set; }
        public bool IsDeleted { get; set; }
    }
}
