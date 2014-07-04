using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Models
{
    class ServicoModel
    {
        public int IdServico { get; set; }

        public string TipoServico { get; set; }

        public string Parceiro { get; set; }

        public string TelefoneParceiro { get; set; }

        public decimal ValorServico  { get; set; }

        public decimal ValorCobradoAoCliente { get; set; }
    
    
    }

}
