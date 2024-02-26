
using Kata.HotDrinks.Domain.DomainObjects;
using Kata.HotDrinks.Domain.Ports;
using Kata.HotDrinksDistributor.Data;
using Microsoft.EntityFrameworkCore;

namespace Kata.HotDrinks.DataAccess.Repositories
{
    public class RecetteRepository : IRecetteRepository
    {
        private readonly HotDrinksContext _context;

        public RecetteRepository(HotDrinksContext hotDrinksContext)
        {
            _context = hotDrinksContext;
        }

        public async Task<IList<Recette>> GetAllRecettes()
        {

            return await _context.Recettes
                            .Include(recette => recette.DosageIngredients)
                            .ThenInclude(dosage => dosage.Ingredient)
                            .AsNoTracking()
                            .ToListAsync();
        }

        public Task<Recette> GetRecetteById(int recetteId)
        {
            throw new NotImplementedException();
        }
    }
}
