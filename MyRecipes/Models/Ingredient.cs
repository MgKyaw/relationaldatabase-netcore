namespace MyRecipes.Models
{
    public class Ingredient 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UnitsOfMeasureId { get; set; }
        public int Amount { get; set; }

        public virtual UnitsOfMeasure UnitsOfMeasure { get; set; }
        public virtual ICollection<RecipeIngredient> IngredientRecipes { get; set; }
    }
}