using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaApp.Models
{
    public class Productos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductoId { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Estado { get; set; }

        public virtual ICollection<Facturas_Detalle> Detalles { get; set; } = new List<Facturas_Detalle>();

    }
}