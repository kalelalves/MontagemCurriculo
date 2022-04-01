using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MontagemCurriculo.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        [Required(ErrorMessage="Campo Obrigatório")]
        [StringLength(50, ErrorMessage="Use menos caracteres")]
        [EmailAddress(ErrorMessage ="Email Inválido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(50, ErrorMessage = "Use menos caracteres")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public ICollection<InformacaoLogin> InformacoesLogin { get; set;}
        public ICollection<Curriculo> Curriculos { get; set; }
    }
}
