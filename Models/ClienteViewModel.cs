using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class ClienteViewModel
    {
        [Required(ErrorMessage ="Este campo e obrigatorio")]
        [StringLength(100, ErrorMessage = "O nome precisa ter no mínimo 5 letras",MinimumLength = 5)]
        public string Nome { get; set; }
         [Required(ErrorMessage ="Este campo e obrigatorio")]
        [DisplayName("CPF")]
        public int cpf {get;set;}
         [Required(ErrorMessage ="Este campo e obrigatorio")]
        public string Email { get; set; }
         [Required(ErrorMessage ="Este campo e obrigatorio")]
        [DisplayName("Contato")]
        public string Contato { get; set; }
          [Required(ErrorMessage ="Este campo e obrigatorio")]
         [DisplayName("Data de Cadastro")]
        public DateTime DataDeCadastro {get;set;}


        

        [DisplayName("Endereço")]
         [Required(ErrorMessage ="Este campo e obrigatorio")]
        public string Endereco { get; set; }

    }
}
