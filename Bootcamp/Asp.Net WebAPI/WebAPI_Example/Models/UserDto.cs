using System.ComponentModel.DataAnnotations;

namespace ExampleWebAPI.Models
{
    public class UserDto
    {
        [Required]
        public string FirstName { get; set; } = "";
        [Required(ErrorMessage = "Please provide your last name..")]
        public string LastName { get; set; } = "";
        [Required]
        [EmailAddress]
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
        [Required]
        [MinLength(5, ErrorMessage = "The address must be at least 5 characters...")]
        [MaxLength(20, ErrorMessage = "The address must be less than 20 characters...")]
        public string Address { get; set; } = "";
    }
}
