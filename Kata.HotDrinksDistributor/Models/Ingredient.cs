using System.ComponentModel.DataAnnotations.Schema;

namespace Kata.HotDrinksDistributor.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        
        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }
    }
}
