using Microsoft.EntityFrameworkCore;

namespace MyRecipes.Models
{
    public class MyRecipesDbContext : DbContext
    {
        public MyRecipesDbContext(DbContextOptions<MyRecipesDbContext> options)
            : base(options)
        { }

        public DbSet<FoodEthnicity> FoodEthnicities { get; set; }
        public DbSet<FoodType> FoodTypes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        public DbSet<UnitsOfMeasure> UnitsOfMeasures { get; set; }
    }
}