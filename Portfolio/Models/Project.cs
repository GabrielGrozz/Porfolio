using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class Project
    {
        [Required(ErrorMessage ="Id não informado")]
        [Display(Name ="ProjectId")]
        public int ProjectId { get; set; }

        [Required(ErrorMessage ="nome do projeto não informado")]
        [Display(Name = "Nome do projeto")]
        public string ProjectName { get; set; }

        [Required(ErrorMessage ="descrição do projeto não informado")]
        [Display(Name = "Descrição do projeto")]
        public string ProjectDescription { get; set; }


    }
}
