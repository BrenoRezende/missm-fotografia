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
        public string NomeCliente { get; set; }
        public string StatusPedido { get; set; }
        public DateTime DataCriacao { get; set; }

        public int IdServico { get; set; }
        public string NomeServico { get; set; }
        public string NomeParceiro { get; set; }
        public string TelefoneParceiro { get; set; }
        public decimal ValorServico { get; set; }
        public decimal ValorCobradoAoCliente { get; set; }
        
        public int Quantidade { get; set; }

    }
}
