using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context) { }

        public async Task<User> GetByEmail(string email, CancellationToken cancellationToken)
        {
            return await Context.Users.FirstOrDefaultAsync(x => x.Email.ToLower().Equals(email.ToLower()), cancellationToken);
        }

        public async Task<User> GetByName(string name, CancellationToken cancellationToken)
        {
            return await Context.Users.FirstOrDefaultAsync(x => (x.FirstName + x.LastName).ToLower().Contains(name.ToLower()), cancellationToken);
        }
    }
}
