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
        public int IdPedido { get; set; }
        public int IdProduto { get; set; }

    }
}
