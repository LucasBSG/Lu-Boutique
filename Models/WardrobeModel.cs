using System.ComponentModel.DataAnnotations;
namespace LuBoutique.Models;

public class TodoItem
{
    public long Id { get; set; }
    [Required]
    [StringLength(100)]
    public string? Name{ get; set; }
    public bool IsComplete { get; set; }
}
