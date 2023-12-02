using minozas_catering_api_dotnet.Entities;
using minozas_catering_api_dotnet.Services;

namespace minozas_catering_api_dotnet.Schema.Queries
{
    [ExtendObjectType("Query")]
    public class FoodQuery
    {
        private readonly FoodService _foodService;
        public FoodQuery(FoodService foodService)
        {
            _foodService = foodService;
        }
        public async Task<List<Food>> FindAll()
        {
            return await _foodService.findAll();
        }
    }
}
