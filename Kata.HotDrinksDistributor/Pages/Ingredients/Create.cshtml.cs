using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Kata.HotDrinksDistributor.Data;
using Kata.HotDrinksDistributor.Models;

namespace Kata.HotDrinksDistributor.Pages.Ingredients
{
    public class CreateModel : PageModel
    {
        private readonly Kata.HotDrinksDistributor.Data.HotDrinksContext _context;

        public CreateModel(Kata.HotDrinksDistributor.Data.HotDrinksContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Ingredient Ingredient { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Ingredients == null || Ingredient == null)
            {
                return Page();
            }

            _context.Ingredients.Add(Ingredient);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
