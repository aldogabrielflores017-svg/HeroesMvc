using System.ComponentModel.DataAnnotations;

namespace HeroesMvc.Models;

public class Heroe
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    [Display(Name = "Nombre del héroe")]
    public string Nombre { get; set; } = string.Empty;
}
