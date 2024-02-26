
namespace Kata.HotDrinksDistributor.Models
{
    public class Recette
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<DosageIngredient> DosageIngredients { get; set; } = null!;
    }
}
