﻿
namespace Kata.HotDrinks.Domain.DomainObjects
{
    public class DosageIngredient
    {
        public int Id { get; set; }
        public int IngredientId { get; set; }
        public int RecetteId { get; set; }
        public int Dosage { get; set; }
        public Ingredient Ingredient { get; set; } = null!;        
    }
}
