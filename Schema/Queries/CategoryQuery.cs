using minozas_catering_api_dotnet.Entities;
using minozas_catering_api_dotnet.Services;

namespace minozas_catering_api_dotnet.Schema.Queries
{
    [ExtendObjectType("Query")]
    public class CategoryQuery
    {
        private readonly CategoryService _categoryService;
        public CategoryQuery(CategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<List<Category>> FindAllCategory()
        {
            return await _categoryService.findAll();
        }
    }
}
