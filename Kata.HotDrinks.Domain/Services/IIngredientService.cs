using Kata.HotDrinks.Domain.DomainObjects;

namespace Kata.HotDrinks.Domain.Services
{
    public interface IIngredientService
    {
        Task<IList<Ingredient>> GetAllIngredients();
    }
}
