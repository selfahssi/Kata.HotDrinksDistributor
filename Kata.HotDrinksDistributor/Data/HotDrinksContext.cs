using Kata.HotDrinksDistributor.Models;
using Microsoft.EntityFrameworkCore;


namespace Kata.HotDrinksDistributor.Data
{
    public class HotDrinksContext : DbContext
    {
        public DbSet<Ingredient> Ingredients { get; set; } = null!;
        public DbSet<DosageIngredient> DosageIngredients { get; set; } = null!;
        public DbSet<Recette> Recettes { get; set; } = null!;

        public HotDrinksContext(DbContextOptions<HotDrinksContext> options) : base(options)
        {
            
        }
        
    }
}
