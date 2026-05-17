using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TiendaApp.Models;

public class Clientes
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ClienteId { get; set; }
    public string Identificacion { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Correo { get; set; }
    public string Telefono { get; set; }  
    public string Direccion { get; set; }
    public DateTime FechaRegistro { get; set; }
    public bool Estado { get; set; }

    public virtual ICollection<Facturas> Facturas { get; set; } = new List<Facturas>();
}