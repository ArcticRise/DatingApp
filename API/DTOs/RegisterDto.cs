using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        //Data Annotations (make sure that no null is accepted)
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}