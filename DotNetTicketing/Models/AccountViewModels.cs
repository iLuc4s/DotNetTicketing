using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace DotNetTicketing.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Deze browser onthouden?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Paswoord")]
        public string Password { get; set; }

        [Display(Name = "Mij onthouden?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {

        [Required]
        [Display(Name = "Voornaam")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Achternaam")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Tel nummer")]
        public string TelNumber { get; set; }

        [Required]
        [Display(Name = "Gsm nummer")]
        public string CellNumber { get; set; }

        [Required]
        [Display(Name = "Wie is jou verantwoordelijke?")]
        public string Resp { get; set; }

        [Required]
        [Display(Name = "Wat doe jij?")]
        public int Role { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "De {0} moet tenminste {2} karakters lang zijn.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Paswoord")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Bevestig paswoord")]
        [Compare("Password", ErrorMessage = "Het paswoord en het te bevestigen paswoord komen niet overeen.")]
        public string ConfirmPassword { get; set; }

        private List<Role> _Roles = new List<Models.Role> { new Role(1, "User"), new Role(2, "Dispatcher"), new Role(3, "Manager"), new Role(4, "Solver"), new Role(5, "Administrator") };

        public IEnumerable<System.Web.Mvc.SelectListItem> Roles
        {
            get
            {
                return new System.Web.Mvc.SelectList(_Roles, "ID", "Name");
            }
        }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "De {0} moet tenminste {2} karakters lang zijn.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Het paswoord en het te bevestigen paswoord komen niet overeen.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
