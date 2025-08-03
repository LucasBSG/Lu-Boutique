using System.ComponentModel.DataAnnotations;

namespace LuBoutique.Models;

public class RegisterViewModel
{
    [Required(ErrorMessage = "O nome é obrigatório")]
    [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres")]
    public string Nome { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "O email é obrigatório")]
    [EmailAddress(ErrorMessage = "Email inválido")]
    public string Email { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "A senha é obrigatória")]
    [StringLength(100, MinimumLength = 6, ErrorMessage = "A senha deve ter entre 6 e 100 caracteres")]
    [DataType(DataType.Password)]
    public string Senha { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Confirme a senha")]
    [DataType(DataType.Password)]
    [Compare("Senha", ErrorMessage = "As senhas não conferem")]
    public string ConfirmarSenha { get; set; } = string.Empty;
    
    [Phone(ErrorMessage = "Telefone inválido")]
    public string? Telefone { get; set; }
}
