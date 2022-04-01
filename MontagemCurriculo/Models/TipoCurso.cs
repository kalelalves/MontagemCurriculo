using System.Collections.Generic;

namespace MontagemCurriculo.Models
{
    public class TipoCurso
    {
        public int TipoCursoId { get; set; }

        public string TipoCursoName { get; set; }

        public ICollection<FormacaoAcademica> FormacoesAcademicas { get; set; }

    }
}
