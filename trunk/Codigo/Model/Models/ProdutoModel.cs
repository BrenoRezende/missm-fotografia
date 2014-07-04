using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Model.App_GlobalResources;

namespace Model.Models
{
    [Serializable]
    public class ProdutoModel
    {
        [Required(ErrorMessageResourceType = typeof(Mensagens),
            ErrorMessageResourceName = "erro_requerido")]
        public int IdProduto { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
            ErrorMessageResourceName = "erro_requerido")]
        [StringLength(50)]
        public string Nome { get; set; }

        [DisplayName("Número de Páginas")]
        public int? NumeroDePaginas { get; set; }

        [StringLength(50)]
        public string Formato { get; set; }

        [DisplayName("Número de Imagens")]
        public int? NumeroDeImagens { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
            ErrorMessageResourceName = "erro_requerido")]
        [DisplayName("Valor do Produto")]
        public decimal ValorDoProduto { get; set; }

        [DisplayName("Valor por Imagem Adicional")]
        public decimal? ValorImagemAdicional { get; set; }
    }
}
