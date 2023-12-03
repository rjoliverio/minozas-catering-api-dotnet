using Microsoft.EntityFrameworkCore;
using minozas_catering_api_dotnet.Context;
using minozas_catering_api_dotnet.Entities;

namespace minozas_catering_api_dotnet.Services
{
    public class CategoryService
    {
        private readonly IDbContextFactory<StoreContext> _contextFactory = default!;
        public CategoryService(IDbContextFactory<StoreContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }
        public async Task<List<Category>> findAll()
        {
            using (StoreContext context = _contextFactory.CreateDbContext())
            {
                return await context.Category.ToListAsync();
            }
        }
    }
}
