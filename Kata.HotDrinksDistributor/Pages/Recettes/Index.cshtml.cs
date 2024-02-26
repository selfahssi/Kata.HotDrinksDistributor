using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Kata.HotDrinksDistributor.Data;
using Kata.HotDrinksDistributor.Models;

namespace Kata.HotDrinksDistributor.Pages.Recettes
{
    public class IndexModel : PageModel
    {
        private readonly Kata.HotDrinksDistributor.Data.HotDrinksContext _context;

        public IndexModel(Kata.HotDrinksDistributor.Data.HotDrinksContext context)
        {
            _context = context;
        }

        public IList<Recette> Recette { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Recettes != null)
            {
                Recette = await _context.Recettes.ToListAsync();
            }
        }
    }
}
