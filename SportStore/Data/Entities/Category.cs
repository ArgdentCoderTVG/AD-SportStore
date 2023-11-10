using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportStore.Data.Entities
{
    public class Category
    {
        // Constants, member variables
        const byte MAXLENGTH_FOR_STRINGS = 100;

        [Key]
        public int Id { get; set; }
        
        [Column, Required, MaxLength(MAXLENGTH_FOR_STRINGS)]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}