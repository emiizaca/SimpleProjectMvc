using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 2)]
        [Required]
        [Display(Name = "Título")]
        public string? Title { get; set; }

        [Display(Name = "Fecha de Lanzamiento")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }//Solo se muestra la fecha, no información horaria.

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Display(Name = "Género")]
        public string? Genre { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Precio")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string? Rating { get; set; }
    }
}
