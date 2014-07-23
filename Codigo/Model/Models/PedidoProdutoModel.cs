using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Model.App_GlobalResources;

namespace Model.Models
{

    public class PedidoProdutoModel
    {
        public int idPedidoProduto { get; set; }

        public int idPedido { get; set; }

        public int idProduto { get; set; }

        public decimal valorProduto { get; set; }

        public decimal valorImagemAdicional { get; set; }

        public int quantidade { get; set; }
        
    }
}
