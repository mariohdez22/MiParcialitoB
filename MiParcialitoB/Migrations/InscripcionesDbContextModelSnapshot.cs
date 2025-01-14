﻿// <auto-generated />
using MiParcialitoB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MiParcialitoB.Migrations
{
    [DbContext(typeof(InscripcionesDbContext))]
    partial class InscripcionesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("MiParcialitoB.Models.Cursos", b =>
                {
                    b.Property<int>("CursoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CursoID"));

                    b.Property<string>("NombreCurso")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CursoID");

                    b.ToTable("DCursos");
                });

            modelBuilder.Entity("MiParcialitoB.Models.Estudiantes", b =>
                {
                    b.Property<int>("EstudianteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("EstudianteID"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("EstudianteID");

                    b.ToTable("DEstudiantes");
                });

            modelBuilder.Entity("MiParcialitoB.Models.Inscripciones", b =>
                {
                    b.Property<int>("InscripcionesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("InscripcionesID"));

                    b.Property<int>("CursoID")
                        .HasColumnType("int");

                    b.Property<int>("EstudianteID")
                        .HasColumnType("int");

                    b.HasKey("InscripcionesID");

                    b.HasIndex("CursoID");

                    b.HasIndex("EstudianteID");

                    b.ToTable("DInscripciones");
                });

            modelBuilder.Entity("MiParcialitoB.Models.Inscripciones", b =>
                {
                    b.HasOne("MiParcialitoB.Models.Cursos", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MiParcialitoB.Models.Estudiantes", "Estudiante")
                        .WithMany()
                        .HasForeignKey("EstudianteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");

                    b.Navigation("Estudiante");
                });
#pragma warning restore 612, 618
        }
    }
}
