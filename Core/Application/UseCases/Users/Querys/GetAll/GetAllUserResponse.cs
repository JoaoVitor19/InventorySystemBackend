namespace Application.UseCases.Users.Querys.GetAll;

public sealed record GetAllUserResponse
{
    public Guid Id { get; set; }
    public string? Email { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}