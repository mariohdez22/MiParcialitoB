using System.ComponentModel.DataAnnotations;

namespace MiParcialitoB.Models
{
    public class Estudiantes
    {
        [Key]
        public int EstudianteID { get; set; }

        [Required]
        public string Nombre { get; set; } = string.Empty;
    }
}
