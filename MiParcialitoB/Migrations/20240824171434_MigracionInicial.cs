using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiParcialitoB.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DCursos",
                columns: table => new
                {
                    CursoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreCurso = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DCursos", x => x.CursoID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DEstudiantes",
                columns: table => new
                {
                    EstudianteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEstudiantes", x => x.EstudianteID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DInscripciones",
                columns: table => new
                {
                    InscripcionesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EstudianteID = table.Column<int>(type: "int", nullable: false),
                    CursoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DInscripciones", x => x.InscripcionesID);
                    table.ForeignKey(
                        name: "FK_DInscripciones_DCursos_CursoID",
                        column: x => x.CursoID,
                        principalTable: "DCursos",
                        principalColumn: "CursoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DInscripciones_DEstudiantes_EstudianteID",
                        column: x => x.EstudianteID,
                        principalTable: "DEstudiantes",
                        principalColumn: "EstudianteID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_DInscripciones_CursoID",
                table: "DInscripciones",
                column: "CursoID");

            migrationBuilder.CreateIndex(
                name: "IX_DInscripciones_EstudianteID",
                table: "DInscripciones",
                column: "EstudianteID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DInscripciones");

            migrationBuilder.DropTable(
                name: "DCursos");

            migrationBuilder.DropTable(
                name: "DEstudiantes");
        }
    }
}
