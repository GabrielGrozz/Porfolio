using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class Technology
    {
        [Required(ErrorMessage = "Id não informado")]
        [Display(Name = "TechnologyId")]
        public int TechnologyId {get;set;}

        [Required(ErrorMessage = "Nome da tecnologia não informado")]
        [Display(Name = "Nome da tecnologia")]
        public string TechnologyName { get;set;}

        [Required(ErrorMessage = "Descrição da tecnologia não informado")]
        [Display(Name = "Descrição da tecnologia")]
        public string TechnologyDescription { get;set;}

        [Required(ErrorMessage = "Documentação da tecnologia não informado")]
        [Display(Name = "Documentação da tecnologia")]
        public string TechnologyDocumentation { get;set;}

    }
}
