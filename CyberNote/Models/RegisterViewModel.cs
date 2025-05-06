using System.ComponentModel.DataAnnotations;

namespace CyberNote.Models;

public class RegisterViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    
    [Required]
    [Compare("Password", ErrorMessage = "Пароли не совпадают!")]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; }
}