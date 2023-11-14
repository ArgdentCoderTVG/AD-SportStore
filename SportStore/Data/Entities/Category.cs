using System.ComponentModel.DataAnnotations;

namespace SportStore.Data.Entities
{
    public class Category
    {
        // Constants, member variables
        const byte MAXLENGTH_FOR_STRINGS = 100;

        public int Id { get; set; }
        
        [MaxLength(MAXLENGTH_FOR_STRINGS)]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}