using System.ComponentModel.DataAnnotations;

namespace MontagemCurriculo.Models
{
    public class Objetivo
    {
        public int ObjetivoId { get; set; }

        [Required(ErrorMessage  = "Descrisção obrigatória")]
        [StringLength(1000,ErrorMessage ="Descrcao muito longa")]
        [DataType(DataType.MultilineText)]
        public string CurriculoId { get; set; }
        public int Nome { get; set; }


    }
}
