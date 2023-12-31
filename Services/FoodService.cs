using Microsoft.EntityFrameworkCore;
using minozas_catering_api_dotnet.Context;
using minozas_catering_api_dotnet.Entities;

namespace minozas_catering_api_dotnet.Services
{
    public class FoodService
    {
        private readonly IDbContextFactory<StoreContext> _contextFactory = default!;
        public FoodService(IDbContextFactory<StoreContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }
        public async Task<List<Food>> findAll(string category, string searchQuery)
        {
            using (StoreContext context = _contextFactory.CreateDbContext())
            {
                return await context.Food
                .Include(i => i.Category)
                .Where(c => c.Category.Name.Contains(category))
                .Where(f => f.Name.ToLower().Contains(searchQuery.ToLower()))
                .ToListAsync();
            }
        }
    }
}
