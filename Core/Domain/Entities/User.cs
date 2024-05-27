using Domain.Enums;

namespace Domain.Entities
{
    public sealed class User : BaseEntity
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PictureUrl { get; set; }
        public bool IsActive { get; set; } = true;
        public ProfileType ProfileType { get; set; }
        public DateTimeOffset? DateOfBirth { get; set; }
    }
}
