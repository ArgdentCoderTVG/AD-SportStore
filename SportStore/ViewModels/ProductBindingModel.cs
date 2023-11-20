using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace SportStore.ViewModels
{
    public class ProductBindingModel
    {
        [Required(ErrorMessage = "Name is required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required!")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is required!")]
        [DataType(DataType.Date)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Geslacht is verplicht!")]
        [Display(Name = "Geslacht")]
        public Gender? Gender { get; set; }

        [Required(ErrorMessage = "Email is verplicht!")]
        [EmailAddress(ErrorMessage = "Dit is geen geldig email-adres!")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Wachtwoord is verplicht!")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Wachtwoord moet min. 8 en max. 100 karakters lang zijn!")]
        public string Password { get; set; }

        [Display(Name = "Schrijf me in voor de niewsbrief")]
        public bool Newsletter { get; set; }

        public IEnumerable<SelectListItem> Languages { get; set; } = new List<SelectListItem>()
        {
            new SelectListItem(){ Text="Nederlands",  Value="NL"},
            new SelectListItem(){ Text="Frans",  Value="FR"},
            new SelectListItem(){ Text="Engels",  Value="EN"},
        };

        [Required(ErrorMessage = "Taal is verplicht!")]
        [Display(Name = "Taal")]
        public string SelectedLanguage { get; set; }
    }
}
