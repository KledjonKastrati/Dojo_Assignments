#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectIdea.Models
{
    public class LoginUser
    {
        [Required]
        [Display(Name = "Email:")]
        public string LoginEmail { get; set; }

        [Required]
        [Display(Name = "Password:")]
        [DataType(DataType.Password)]
        public string LoginPassword { get; set; }
    }
}