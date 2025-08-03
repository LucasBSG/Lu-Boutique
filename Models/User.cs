using System.ComponentModel.DataAnnotations;

namespace LuBoutique.Models;

public class User
{
    public int Id { get; set; }
    
    [Required]
    [StringLength(100)]
    public string Nome { get; set; } = string.Empty;
    
    [Required]
    [EmailAddress]
    [StringLength(255)]
    public string Email { get; set; } = string.Empty;
    
    [Required]
    [StringLength(255)]
    public string SenhaHash { get; set; } = string.Empty;
    
    [StringLength(20)]
    public string? Telefone { get; set; }
    
    public DateTime DataCadastro { get; set; } = DateTime.UtcNow;
    
    public bool Ativo { get; set; } = true;
}
