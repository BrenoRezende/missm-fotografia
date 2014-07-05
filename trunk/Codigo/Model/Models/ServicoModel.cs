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
    public class ServicoModel
    {
        public int IdServico { get; set; }

        public string TipoServico { get; set; }
    
        public string Parceiro { get; set; }
    
        public string TelefoneParceiro { get; set; }
               
        public decimal ValorServico  { get; set; }
        
        public decimal ValorCobradoAoCliente { get; set; }
      
   }
}
