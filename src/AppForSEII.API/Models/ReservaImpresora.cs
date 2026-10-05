using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppForSEII.API.Models;

public class ReservaImpresora
{
    [Key]
    public int Id { get; set; }

    public DateTime FechaReserva { get; set; }

    [Required]
    [StringLength(50)]
    public string NombreCliente { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string ApellidosCliente { get; set; } = string.Empty;

    [Required]
    [StringLength(250)]
    public string DireccionFacturacion { get; set; } = string.Empty;

    [Column(TypeName = "decimal(10,2)")]
    [Range(typeof(decimal), "0", "99999999.99",
        ParseLimitsInInvariantCulture = true)]
    public decimal PrecioTotal { get; set; }

    [EnumDataType(typeof(MetodoPago))]
    public MetodoPago MetodoPago { get; set; }

    [Required]
    public string ClienteId { get; set; } = string.Empty;

    [ForeignKey(nameof(ClienteId))]
    public Cliente Cliente { get; set; } = null!;
}