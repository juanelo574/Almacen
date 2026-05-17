using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TiendaApp.Models;

public class Facturas_Detalle
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int DetalleId { get; set; }

    [ForeignKey("Factura")] 
    public int FacturaId { get; set; }

    [ForeignKey("Producto")]  
    public int ProductoId { get; set; }

    public int Cantidad { get; set; }
    public decimal PrecioUnitario { get; set; }
    public decimal Descuento { get; set; }
    public decimal SubTotal { get; set; }

    public virtual Facturas Factura { get; set; } = null!;
    public virtual Productos Producto { get; set; } = null!;
}