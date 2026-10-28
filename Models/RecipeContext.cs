using Microsoft.EntityFrameworkCore;
namespace RecipeMealPlanner.Models
{
    public class RecipeContext : DbContext
    {
        public RecipeContext(DbContextOptions<RecipeContext> options) : base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Data
            modelBuilder.Entity<Recipe>().HasData(
                new Recipe
                {
                    Id = 1,
                    Title = "Classic Avocados Toast",
                    Category = "Breakfast",
                    PrepTimeMinutes = 10,
                    Servings = 2,
                    Instructions = "Toast the bread. Mash avocados with lemon juice, salt, and pepper. Spread evenly on toasted bread."
                },
                new Recipe
                {
                    Id = 2,
                    Title = "Creamy Garlic Parmesan Pasta",
                    Category = "Dinner",
                    PrepTimeMinutes = 25,
                    Servings = 4,
                    Instructions = "Boil fettuccine. In a skillet, melt butter with minced garlic. Add heavy cream and grated parmesan. Toss pasta into cream sauce."
                },
                new Recipe
                {
                    Id = 3,
                    Title = "Berry Blast Smoothie Bowl",
                    Category = "Snack",
                    PrepTimeMinutes = 5,
                    Servings = 1,
                    Instructions = "Blend frozen berries, banana, and almond milk until smooth. Pour into a bowl and top with chia seeds and granolas."
                }
            );
        }
    }
}
