using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductCatalogApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        //No permite null en el nombre
        [Required(ErrorMessage ="El nombre es obligatorio")]
        [StringLength(100,MinimumLength =4, ErrorMessage ="El nombre debe de tener entre 4 y 100 caracteres")]
        public string Nombre { get; set; } = string.Empty;
        //No permite negativos
        [Range(0.01,double.MaxValue, ErrorMessage ="El precio debe ser mayor a 0")]
        //Guarda precio con 18 digitos, dos de ellos decimales
        [Column (TypeName ="decimal(18,2)")]
        public decimal Precio { get; set; }
        [Required(ErrorMessage = "La categoria es obligatoria")]
        public string Categoria { get; set; } = string.Empty;

    }
}
