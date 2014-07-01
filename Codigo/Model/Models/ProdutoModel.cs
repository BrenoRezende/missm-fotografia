using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Model.Models
{
    [Serializable]
    public class ProdutoModel
    {
        [Required]
        [DisplayName("Código")] 
        public int IdProduto { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        [DisplayName("Número de Páginas")]
        public int? NumeroDePaginas { get; set; }

        [StringLength(50)]
        public string Formato { get; set; }

        [DisplayName("Número de Imagens")]
        public int? NumeroDeImagens { get; set; }

        [Required]
        [DisplayName("Valor do Produto")]
        public decimal ValorDoProduto { get; set; }

        [DisplayName("Valor por Imagem Adicional")]
        public decimal ValorImagemAdicional { get; set; }
    }
}
