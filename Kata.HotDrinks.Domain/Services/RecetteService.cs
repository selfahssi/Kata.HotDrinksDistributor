using Kata.HotDrinks.Domain.DomainObjects;
using Kata.HotDrinks.Domain.Ports;

namespace Kata.HotDrinks.Domain.Services
{
    public class RecetteService : IRecetteService
    {
        private readonly IRecetteRepository _recetteRepository;

        public RecetteService(IRecetteRepository recetteRepository)
        {
            _recetteRepository = recetteRepository;
        }
        public async Task<IList<Recette>> GetAllRecettes()
        {
            if (_recetteRepository == null)
            {
                throw new ArgumentNullException("Erreur technique");
            }

            return await _recetteRepository.GetAllRecettes();
        }

        public async Task<Recette?> GetRecetteById(int idRecette)
        {
            var recettes = await _recetteRepository.GetAllRecettes();
            
            return recettes.SingleOrDefault(x => x.Id == idRecette); 
        }

    }
}
