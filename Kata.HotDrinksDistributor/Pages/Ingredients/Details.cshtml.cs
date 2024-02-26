using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Kata.HotDrinksDistributor.Data;
using Kata.HotDrinksDistributor.Models;

namespace Kata.HotDrinksDistributor.Pages.Ingredients
{
    public class DetailsModel : PageModel
    {
        private readonly Kata.HotDrinksDistributor.Data.HotDrinksContext _context;

        public DetailsModel(Kata.HotDrinksDistributor.Data.HotDrinksContext context)
        {
            _context = context;
        }

      public Ingredient Ingredient { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Ingredients == null)
            {
                return NotFound();
            }

            var ingredient = await _context.Ingredients.FirstOrDefaultAsync(m => m.Id == id);
            if (ingredient == null)
            {
                return NotFound();
            }
            else 
            {
                Ingredient = ingredient;
            }
            return Page();
        }
    }
}
