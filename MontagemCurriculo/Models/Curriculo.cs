using System.Collections.Generic;

namespace MontagemCurriculo.Models
{
    public class Curriculo
    {
        public int CorriculoId { get; set; }

        public string Nome { get; set; }

        public int UsuarioId { get; set; }

        public ICollection<Objetivo> Objetivos { get; set; }

        public ICollection<FormacaoAcademica> FormacaoAcademica { get; set; }

        public ICollection<ExperienciaProfissional> ExperienciaProfissional { get; set; }
        public ICollection<Idioma> Idiomas { get; set;}



    }
}
