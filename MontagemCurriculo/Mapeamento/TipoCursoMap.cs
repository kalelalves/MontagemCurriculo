using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MontagemCurriculo.Models;

namespace MontagemCurriculo.Mapeamento
{
    public class TipoCursoMap : IEntityTypeConfiguration<TipoCurso>
    {
        public void Configure(EntityTypeBuilder<TipoCurso> builder)
        {
            builder.HasKey(tc => tc.TipoCursoId);

            builder.Property(tc =>tc.Tipo ).IsRequired();
            builder.HasIndex(tc=>tc.Tipo).IsUnique();

            object p = builder.HasMany(tc => tc.FormacoesAcademicas).WithOne(tc => tc.TipoCurso).OnDelete(DeleteBehavior.Cascade);

        }

       
    }
}
