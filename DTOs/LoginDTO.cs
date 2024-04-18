using System.ComponentModel.DataAnnotations;

namespace CP_MVC_RM550889.DTOs
{
    public class LoginDTO
    {
        [Required]
        [EmailAddress]
        public string UserEmail { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }
    }
}
