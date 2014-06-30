using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Model.Models
{
    [Serializable]
    public class ProdutoModel
    {
        [Required]
        [Display(Name = "Código")]
        public int IdProduto { get; set; }

        [Required]
        [Display(Name = "Nome")]
        [StringLength(50)]
        public string NomeProduto { get; set; }

        [Display(Name = "Número de Páginas")]
        public int? NumeroDePaginas { get; set; }

        [Display(Name = "Formato")]
        [StringLength(50)]
        public string Formato { get; set; }

        [Display(Name = "Número de Imagens")]
        public int? NumeroDeImagens { get; set; }

        [Required]
        [Display(Name = "Valor do Produto")]
        public decimal ValorDoProduto { get; set; }

        [Display(Name = "Valor por Imagem Adicional")]
        public decimal? ValorImagemAdicional { get; set; }
    }
}
