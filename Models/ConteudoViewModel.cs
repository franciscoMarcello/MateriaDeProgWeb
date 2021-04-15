using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace WebApp.Models
{
    public class ConteudoViewModel
    {
        [Required(ErrorMessage ="Este campo é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage ="Este campo é obrigatório")]
        [DisplayName("Data do conteudo")]
        public DateTime DataDoCadastro { get; set; }
        [Required(ErrorMessage ="Este campo é obrigatório")]
        public string Texto { get; set; }
        [DisplayName("Tipo de conteudo")]
        [Required(ErrorMessage ="Este campo é obrigatório")]
        public string tipoDeConteudo { get; set; }
        [DisplayName("Descrição")]
        [Required(ErrorMessage ="Este campo é obrigatório")]
        public string descricao { get; set; }
      
        [DisplayName("Selecione uma imagem")]
        public string LinkImagem { get; set; }
    }
}
