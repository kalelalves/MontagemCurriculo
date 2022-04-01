﻿using Microsoft.EntityFrameworkCore;

namespace MontagemCurriculo.Models
{
    public class Contexto:DbContext
    {
        public DbSet<Curriculo> Curriculos { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }

        public DbSet<TipoCurso> TipoCursos { get; set; }
        public DbSet<FormacaoAcademica> FormacaoAcademicas { get; set; }
        public DbSet<Objetivo> Objetivos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public Contexto (DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }
    }
}
