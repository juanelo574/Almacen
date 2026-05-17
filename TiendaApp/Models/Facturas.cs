// Facturas.cs - Agregar FK explícito (opcional)
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TiendaApp.Models;

public class Facturas
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int FacturaId { get; set; }
    public int NumeroFactura { get; set; }

    [ForeignKey("Cliente")]  
    public int ClienteId { get; set; }
    public DateTime FechaEmision { get; set; }
    public decimal SubTotal { get; set; }
    public decimal IVA { get; set; }
    public decimal Total { get; set; }
    public string Estado { get; set; }
    public string MetodoPago { get; set; }

    public virtual Clientes Cliente { get; set; } = null!;
    public virtual ICollection<Facturas_Detalle> Detalles { get; set; } = new List<Facturas_Detalle>();
}