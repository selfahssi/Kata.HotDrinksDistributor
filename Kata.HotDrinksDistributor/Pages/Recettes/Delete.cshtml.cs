﻿using System;
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
    public class DeleteModel : PageModel
    {
        private readonly Kata.HotDrinksDistributor.Data.HotDrinksContext _context;

        public DeleteModel(Kata.HotDrinksDistributor.Data.HotDrinksContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Recette Recette { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Recettes == null)
            {
                return NotFound();
            }

            var recette = await _context.Recettes.FirstOrDefaultAsync(m => m.Id == id);

            if (recette == null)
            {
                return NotFound();
            }
            else 
            {
                Recette = recette;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Recettes == null)
            {
                return NotFound();
            }
            var recette = await _context.Recettes.FindAsync(id);

            if (recette != null)
            {
                Recette = recette;
                _context.Recettes.Remove(Recette);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}