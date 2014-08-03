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
        [Display(Name = "codigo", ResourceType = typeof(Mensagens))]
        public int IdProduto { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
            ErrorMessageResourceName = "erro_requerido")]
        [StringLength(50)]
        public string Nome { get; set; }

        [Display(Name = "num_paginas", ResourceType = typeof(Mensagens))]
        public int? NumeroDePaginas { get; set; }

        [StringLength(50)]
        public string Formato { get; set; }

        [Display(Name = "num_imagens", ResourceType = typeof(Mensagens))]
        public int? NumeroDeImagens { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
            ErrorMessageResourceName = "erro_requerido")]
        [Display(Name = "valor_produto", ResourceType = typeof(Mensagens))]
        public decimal ValorDoProduto { get; set; }


    }
}
