﻿namespace Kata.HotDrinks.Domain.DomainObjects
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
    }
}
