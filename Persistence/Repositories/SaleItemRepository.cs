using Domain.Entities;
using Domain.Interfaces;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class SaleItemRepository : BaseRepository<SaleItem>, ISaleItemRepository
    {
        public SaleItemRepository(AppDbContext context) : base(context) { }
    }
}
