using Kata.HotDrinks.Domain.DomainObjects;
using Kata.HotDrinks.Domain.Ports;
using Kata.HotDrinksDistributor.Data;
using Microsoft.EntityFrameworkCore;


namespace Kata.HotDrinks.DataAccess.Repositories
{
    public class IngredientRepository : IIngredientRepository
    {
        private readonly HotDrinksContext _context;

        public IngredientRepository(HotDrinksContext hotDrinksContext)
        {
            _context = hotDrinksContext;
        }
        public async Task<IList<Ingredient>> GetAllIngredients()
        {
            return await _context.Ingredients.ToListAsync();            
        }
    }
}
