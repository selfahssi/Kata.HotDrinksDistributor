using Kata.HotDrinks.Domain.DomainObjects;
using Kata.HotDrinks.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Kata.HotDrinksDistributor.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IRecetteService _recetteService;

        public IndexModel(IRecetteService recetteService)
        {
            _recetteService = recetteService;
        }

        public IList<Recette> Recettes { get; set; } = default!;        
        [BindProperty()]
        public int SelectedRecetteId { get; set; }
        public Recette? SelectedRecette { get; set; }

        public async Task OnGetAsync()
        {
            Recettes = await _recetteService.GetAllRecettes();
        }

        public async Task OnPost()
        {
            if (SelectedRecetteId > 0)
            {
                SelectedRecette = await _recetteService.GetRecetteById(SelectedRecetteId);
                Recettes = await _recetteService.GetAllRecettes();
            }            
        }
    }
}
