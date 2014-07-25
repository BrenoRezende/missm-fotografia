using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Model.App_GlobalResources;

namespace Model.Models
{
    public class PedidoEventoModel
    {
        public int IdPedidoEvento { get; set; }

        public int IdPedido { get; set; }
        public string NomeCliente { get; set; }
        public string StatusPedido { get; set; }
        public DateTime DataCriacao { get; set; }

        public int IdEvento { get; set; }
        public string NomeTipoEvento { get; set; }
        public int TotalConvidados { get; set; }
        public decimal ValorTipoEvento { get; set; }

        public int Quantidade { get; set; }
    }
}
