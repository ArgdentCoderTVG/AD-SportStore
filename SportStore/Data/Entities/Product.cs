using SportStore.Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportStore.Data.Entities
{
    public class Product
    {
        // Constants, member variables
        const byte MAXLENGTH_FOR_STRINGS = 100;
        
        [Key]
        public int Id { get; set; } = default;
        [Required, MaxLength(MAXLENGTH_FOR_STRINGS)]
        public string Name { get; set; } = String.Empty;
        [MaxLength(MAXLENGTH_FOR_STRINGS)]
        public string? Description { get; set; } = default;
        [Required]
        public decimal Price { get; set; } = default;
        public string? ImageURL { get; set; } = default;

        [ForeignKey("CategoryFK")]
        public int? CategoryFK { get; set; } = default;
        public Category? Category { get; set; } = default;
    }
}