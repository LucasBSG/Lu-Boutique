using System.ComponentModel.DataAnnotations;

namespace LuBoutique.Models;

public class LoginViewModel
{
    [Required(ErrorMessage = "O email é obrigatório")]
    [EmailAddress(ErrorMessage = "Email inválido")]
    public string Email { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "A senha é obrigatória")]
    [DataType(DataType.Password)]
    public string Senha { get; set; } = string.Empty;
    
    public bool LembrarMe { get; set; }
}
