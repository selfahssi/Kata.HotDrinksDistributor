using Kata.HotDrinks.Domain.DomainObjects;
using Kata.HotDrinks.Domain.Ports;

namespace Kata.HotDrinks.Domain.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly IIngredientRepository _ingredientService;

        public IngredientService(IIngredientRepository ingredientService)
        {
            _ingredientService = ingredientService;
        }

        public Task<IList<Ingredient>> GetAllIngredients()
        {
            if (_ingredientService == null)
            {
                throw new ArgumentNullException("Erreur technique");
            }

            return _ingredientService.GetAllIngredients();
        }
    }
}
