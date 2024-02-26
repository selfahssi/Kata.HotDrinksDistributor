using Kata.HotDrinks.Domain.DomainObjects;

namespace Kata.HotDrinks.Domain.Ports
{
    public interface IIngredientRepository
    {
        Task<IList<Ingredient>> GetAllIngredients();

    }
}
