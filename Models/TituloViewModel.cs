using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace WebApp.Models
{
    public class TituloViewModel
    { 
        [DisplayName("Nome do fornecedor")]
        [Required(ErrorMessage ="O campo é obrigatório")]
        public string NomeDoFornecedor { get; set; }
        
        
        [Required(ErrorMessage ="O campo é obrigatório")]
        public int CNPJ { get; set; }
        
        [Required(ErrorMessage ="O campo é obrigatório")]
         [DisplayName("Data de vencimento")]
        public DateTime VencimentoTitulo { get; set; }

        [Required(ErrorMessage ="O campo é obrigatório")]
         [DisplayName("Valor do titulo")]
        public decimal ValorDoTitulo { get; set; }

      
    }
}
