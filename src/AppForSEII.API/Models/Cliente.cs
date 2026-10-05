using System.ComponentModel.DataAnnotations;

namespace AppForSEII.API.Models;

public class Cliente : ApplicationUser
{
    [Required]
    [StringLength(250)]
    public string DireccionFacturacion { get; set; } = string.Empty;
}