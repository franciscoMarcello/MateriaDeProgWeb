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
        [DisplayName("Descrição:")]
        [Required(ErrorMessage ="O campo Nome é obrigatório")]
        public string Descricao { get; set; }
        [DisplayName("Valor:")]
        [Required(ErrorMessage ="O campo Nome é obrigatório")]
        public decimal Valor { get; set; }
        [DisplayName("Tipo:")]
        [Required(ErrorMessage ="O campo Nome é obrigatório")]
        public string Tipo { get; set; }
    }
}
