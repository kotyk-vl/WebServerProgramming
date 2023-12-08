using System.ComponentModel.DataAnnotations;

namespace SageBook.Lab2_3.MVC_WebAPI.Models.Account
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string? Email { get; set; }

        [Required]
        [Display(Name = "Date of birth")]
        public int Year { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string? Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Passwords should match")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string? PasswordConfirm { get; set; }
    }
}