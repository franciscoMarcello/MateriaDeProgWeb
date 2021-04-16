using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace WebApp.Models
{
    public class ProdutoViewModel
    { 
        [DisplayName("Preço")]
        [Required(ErrorMessage ="O campo Preço é obrigatório")]
        public decimal Preco { get; set; }
        
        [DisplayName("Descrição")]
        [Required(ErrorMessage ="O campo descrição é obrigatório")]
        public string Descricao { get; set; }
        
        [Required(ErrorMessage ="O campo categoria é obrigatório")]
        public string Categoria { get; set; }
        [DisplayName("Codigo do produto")]
        [Required(ErrorMessage ="O campo codigo do produto é obrigatório")]
        public int codigoDoProduto { get; set; }

        [DisplayName("Obeservação")]
        [Required(ErrorMessage ="O campo obeservação é obrigatório")]
        public string Observacao { get; set; }
    }
}
