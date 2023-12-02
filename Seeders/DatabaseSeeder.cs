using minozas_catering_api_dotnet.Entities;

namespace minozas_catering_api_dotnet.Context.Seeders
{
    public class DatabaseSeeder
    {
        public static Category[] categories = new Category[]{
            new Category{Id=1, Name="Main Course"},
            new Category{Id=2, Name="Appetizer"},
            new Category{Id=3, Name="Beverage"},
            new Category{Id=4, Name="Dessert"},
        };
        public static Food[] foods = new Food[]{
            new Food {
                Id=1,
                Name="Spaghetti Carbonara",
                CategoryId=categories[0].Id,
                Rate=5,
                Description="Delicious creamy pasta with pancetta and eggs.",
                Image="https://img.freepik.com/free-photo/authentic-italian-pasta_24972-2334.jpg?w=1060&t=st=1695260902~exp=1695261502~hmac=648e941ed4113c74f9ff232bc99fa0dbc9af4fc05177516e80cd7b2fa00b4c12"
            },
            new Food {
                Id=2,
                Name="Tiramisu",
                CategoryId=categories[3].Id,
                Rate=4,
                Description="Classic Italian dessert with layers of coffee-soaked ladyfingers and mascarpone cheese.",
                Image="https://img.freepik.com/free-photo/layered-chocolate-tiramisu-cake-with-mascarpone-cream-generated-by-ai_188544-18033.jpg?t=st=1695260938~exp=1695264538~hmac=894f0da8529c0dc982048567fe5395f2c6c9a6aa1bf21d1cf668d205af4e603d&w=1380"
            },
            new Food {
                Id=3,
                Name="Chicken Alfredo",
                CategoryId=categories[0].Id,
                Rate=4.5,
                Description="Thin-crust pizza topped with tomato sauce, fresh mozzarella, and basil leaves.",
                Image="https://img.freepik.com/free-photo/side-view-pasta-with-sauce-parmesan-mushrooms-lettuce_176474-2504.jpg?w=740&t=st=1695261078~exp=1695261678~hmac=6541d1678468b9a97fad41d19c49bcf50fc2b9e0d10ee8193f7dc03887c74c1c"
            },
            new Food {
                Id=4,
                Name="Bruschetta",
                CategoryId=categories[1].Id,
                Rate=3.5,
                Description="Toasted bread topped with diced tomatoes, garlic, basil, and olive oil.",
                Image="https://img.freepik.com/free-photo/tasty-bruschetta-with-tomatoes-basil_1220-7130.jpg?w=1060&t=st=1695261055~exp=1695261655~hmac=87f4131596b0ae974ae70c67e131072c102c8ac4c9455e7de00c6f0e2fd858e1"
            },
            new Food {
                Id=5,
                Name="Chocolate Milkshake",
                CategoryId=categories[2].Id,
                Rate=5,
                Description="Rich and creamy chocolate milkshake topped with whipped cream.",
                Image="https://img.freepik.com/free-photo/front-view-chocolate-dessert-glass-with-straw_23-2148603311.jpg?w=360&t=st=1695261027~exp=1695261627~hmac=2fb436de8daf37a93db98ed4994f5eb20b6eee191bd2b0a8aa245a8b558f8a9f"},
        };
    }
}
