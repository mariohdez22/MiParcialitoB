using System.ComponentModel.DataAnnotations;

namespace MiParcialitoB.Models
{
    public class Cursos
    {
        [Key]
        public int CursoID { get; set; }

        [Required]
        public string NombreCurso { get; set; } = string.Empty;
    }
}
