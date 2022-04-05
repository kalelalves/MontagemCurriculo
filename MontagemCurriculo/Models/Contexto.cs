﻿using Microsoft.EntityFrameworkCore;
using MontagemCurriculo.Mapeamento;

namespace MontagemCurriculo.Models
{
    public class Contexto:DbContext
    {
        public DbSet<Curriculo> Curriculos { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }

        public DbSet<Objetivo> TipoCursos { get; set; }
        public DbSet<FormacaoAcademica> FormacaoAcademicas { get; set; }
        public DbSet<Objetivo> Objetivos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public Contexto (DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CurriculoMap());
            modelBuilder.ApplyConfiguration(new ExperienciaProfissionalMap());
            modelBuilder.ApplyConfiguration(new FormacaoAcademicaMap());
            modelBuilder.ApplyConfiguration(new IdiomaMap());
            modelBuilder.ApplyConfiguration(new InformacaoLoginMap());
            modelBuilder.ApplyConfiguration(new ObjetivoMap());
            modelBuilder.ApplyConfiguration(new TipoCursoMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());

        }


    }
}
