using System.ComponentModel.DataAnnotations;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent.ViewModels
{
    public class AddEmployerViewModel
    {
       
        [Required(ErrorMessage = "Please add employer name.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage="Employer name should be between 3-50 characters.")]
        public string? Name { get; set; }
        [Required (ErrorMessage = "Let us know the employer's location.")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Please type between 2-30 characters.")]
        public string? Location { get; set; }
    }
}
