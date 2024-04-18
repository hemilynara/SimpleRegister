using System.ComponentModel.DataAnnotations;

namespace CP_MVC_RM550889.DTOs
{
    public class RegisterDTO
    {
        [Required]
        public string UserName { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string UserEmail { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; } = string.Empty;
        [DataType(DataType.Password)]
        [Compare("UserPassword", ErrorMessage = "As Senhas não são iguais!!")]
        public string ConfirmPassword { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string UserPhone { get; set; } = string.Empty;
    }
}
