using System.ComponentModel.DataAnnotations;

namespace Api.Dtos;

public class RegisterDto
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    
    [Required]
    [StringLength(100, ErrorMessage = "Full name cannot be longer than 100 characters.")]
    public string FullName { get; set; }
}
