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
        [Required(ErrorMessage ="O campo Nome é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome precisa ter no mínimo 5 letras",MinimumLength = 5)]
        public string Nome { get; set; }
        [Required(ErrorMessage ="O campo CPF é obrigatório")]
        [DisplayName("CPF")]
        public int cpf {get;set;}

        public string Sexo { get; set; }
        
        [DisplayName("Número")]
        public int Numero { get; set; }

        [StringLength(7, ErrorMessage = "O CEP precisa ter no mínimo 7 números", MinimumLength=7)]
        public int CEP {get;set;}

   
        public string Bairro { get; set; }
        [Required(ErrorMessage ="O campo telefone é obrigatório")]
        public string Telefone { get; set; }

        [DisplayName("Endereço")]
        public string Endereco { get; set; }

    }
}
