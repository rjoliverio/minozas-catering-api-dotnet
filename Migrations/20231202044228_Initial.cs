using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace minozas_catering_api_dotnet.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Rate = table.Column<double>(type: "double precision", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Food_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Main Course" },
                    { 2, "Appetizer" },
                    { 3, "Beverage" },
                    { 4, "Dessert" }
                });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "Name", "Rate" },
                values: new object[,]
                {
                    { 1, 1, "Delicious creamy pasta with pancetta and eggs.", "https://img.freepik.com/free-photo/authentic-italian-pasta_24972-2334.jpg?w=1060&t=st=1695260902~exp=1695261502~hmac=648e941ed4113c74f9ff232bc99fa0dbc9af4fc05177516e80cd7b2fa00b4c12", "Spaghetti Carbonara", 5.0 },
                    { 2, 4, "Classic Italian dessert with layers of coffee-soaked ladyfingers and mascarpone cheese.", "https://img.freepik.com/free-photo/layered-chocolate-tiramisu-cake-with-mascarpone-cream-generated-by-ai_188544-18033.jpg?t=st=1695260938~exp=1695264538~hmac=894f0da8529c0dc982048567fe5395f2c6c9a6aa1bf21d1cf668d205af4e603d&w=1380", "Tiramisu", 4.0 },
                    { 3, 1, "Thin-crust pizza topped with tomato sauce, fresh mozzarella, and basil leaves.", "https://img.freepik.com/free-photo/side-view-pasta-with-sauce-parmesan-mushrooms-lettuce_176474-2504.jpg?w=740&t=st=1695261078~exp=1695261678~hmac=6541d1678468b9a97fad41d19c49bcf50fc2b9e0d10ee8193f7dc03887c74c1c", "Chicken Alfredo", 4.5 },
                    { 4, 2, "Toasted bread topped with diced tomatoes, garlic, basil, and olive oil.", "https://img.freepik.com/free-photo/tasty-bruschetta-with-tomatoes-basil_1220-7130.jpg?w=1060&t=st=1695261055~exp=1695261655~hmac=87f4131596b0ae974ae70c67e131072c102c8ac4c9455e7de00c6f0e2fd858e1", "Bruschetta", 3.5 },
                    { 5, 3, "Rich and creamy chocolate milkshake topped with whipped cream.", "https://img.freepik.com/free-photo/front-view-chocolate-dessert-glass-with-straw_23-2148603311.jpg?w=360&t=st=1695261027~exp=1695261627~hmac=2fb436de8daf37a93db98ed4994f5eb20b6eee191bd2b0a8aa245a8b558f8a9f", "Chocolate Milkshake", 5.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Food_CategoryId",
                table: "Food",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
