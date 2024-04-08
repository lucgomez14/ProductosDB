using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "varchar(50)")]
        [MaxLength(50, ErrorMessage = "Exceeded the maximum characters")]
        public string Nombre { get; set; }
    }
}
