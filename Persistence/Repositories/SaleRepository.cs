using Domain.Entities;
using Domain.Interfaces;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class SaleRepository : BaseRepository<Sale>, ISaleRepository
    {
        public SaleRepository(AppDbContext context) : base(context) { }
    }
}
