using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeMealPlanner.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PrepTimeMinutes = table.Column<int>(type: "int", nullable: false),
                    Servings = table.Column<int>(type: "int", nullable: false),
                    Instructions = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Category", "Instructions", "PrepTimeMinutes", "Servings", "Title" },
                values: new object[] { 1, "Breakfast", "Toast the bread. Mash avocados with lemon juice, salt, and pepper. Spread evenly on toasted bread.", 10, 2, "Classic Avocados Toast" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Category", "Instructions", "PrepTimeMinutes", "Servings", "Title" },
                values: new object[] { 2, "Dinner", "Boil fettuccine. In a skillet, melt butter with minced garlic. Add heavy cream and grated parmesan. Toss pasta into cream sauce.", 25, 4, "Creamy Garlic Parmesan Pasta" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Category", "Instructions", "PrepTimeMinutes", "Servings", "Title" },
                values: new object[] { 3, "Snack", "Blend frozen berries, banana, and almond milk until smooth. Pour into a bowl and top with chia seeds and granolas.", 5, 1, "Berry Blast Smoothie Bowl" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}
