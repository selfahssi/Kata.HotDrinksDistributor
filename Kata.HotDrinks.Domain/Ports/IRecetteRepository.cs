using Kata.HotDrinks.Domain.DomainObjects;

namespace Kata.HotDrinks.Domain.Ports
{
    public interface IRecetteRepository
    {
        Task<IList<Recette>> GetAllRecettes();
        Task<Recette> GetRecetteById(int recetteId);
    }
}
