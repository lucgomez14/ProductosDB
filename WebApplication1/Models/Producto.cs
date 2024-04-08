using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Helpers;

namespace WebApplication1.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        [MaxLength(50, ErrorMessage = "Exceeded the maximum characters")]
        public string Nombre { get; set; }
        [Mayor0Atributtes]
        public double Precio { get; set; }
        [ForeignKey("Categoria")]
        public int CategoryId { get; set; }
    }
}
