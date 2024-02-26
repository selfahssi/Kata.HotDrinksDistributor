namespace Kata.HotDrinks.Domain.DomainObjects
{
    public class Recette
    {
        const decimal marge = 0.7M;

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public IList<DosageIngredient> DosageIngredients { get; set; } = null!;
        public decimal PurshasePrice => DosageIngredients.Sum(x => x.Ingredient.Price * x.Dosage);
        public decimal SellingPrice => PurshasePrice / marge;
        public decimal Profit => SellingPrice - PurshasePrice;
    }
}
