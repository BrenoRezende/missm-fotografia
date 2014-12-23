using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Model.App_GlobalResources;

namespace Model.Models
{

    public class PedidoServicoModel
    {
        public int IdPedidoServico { get; set; }
        public int IdPedido { get; set; }
        public int IdServico { get; set; }       

    }
}
