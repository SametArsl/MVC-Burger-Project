using System.ComponentModel.DataAnnotations;

namespace MVC_Burger_Project.Models.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
