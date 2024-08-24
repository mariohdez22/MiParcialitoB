using Microsoft.EntityFrameworkCore;

namespace MiParcialitoB.Models
{
    public class InscripcionesDbContext : DbContext
    {
        public InscripcionesDbContext(DbContextOptions<InscripcionesDbContext> options) : base(options)
        {
            
        }

        public DbSet<Estudiantes> DEstudiantes { get; set; }

        public DbSet<Cursos> DCursos { get; set; }

        public DbSet<Inscripciones> DInscripciones { get; set; }
    }
}
