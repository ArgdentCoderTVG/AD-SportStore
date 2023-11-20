using System.ComponentModel.DataAnnotations;

namespace SportStore.Data.Entities
{
    public class Product
    {
        // Constants, member variables
        const byte MAXLENGTH_FOR_STRINGS = 100;
        
        public int ProductId { get; set; } = default;
        [MaxLength(MAXLENGTH_FOR_STRINGS)]
        public string Name { get; set; } = String.Empty;
        [MaxLength(MAXLENGTH_FOR_STRINGS)]
        public string? Description { get; set; } = default;
        public decimal Price { get; set; } = default;
        public string? ImageUrl { get; set; } = default;

        public int? CategoryFK { get; set; } = default;
        public Category? Category { get; set; } = default;
    }
}