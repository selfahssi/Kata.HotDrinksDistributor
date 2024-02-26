using Kata.HotDrinks.Domain.DomainObjects;

namespace Kata.HotDrinks.Domain.Services
{
    public interface IRecetteService
    {
        Task<IList<Recette>> GetAllRecettes();
        Task<Recette?> GetRecetteById(int idRecette);
    }
}
