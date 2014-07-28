using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Model.App_GlobalResources;

namespace Model.Models
{
    public class OrcamentoModel
    {       
        public int IdProduto { get; set; }        
        public string NomeProduto { get; set; }        
        public int NumeroDePaginas { get; set; }
        public string Formato { get; set; }
        public int NumeroDeImagens { get; set; }
        public decimal ValorDoProduto { get; set; }

        public int IdServico { get; set; }        
        public string NomeServico { get; set; }        
        public string NomeParceiro { get; set; }       
        public string TelefoneParceiro { get; set; }       
        public decimal ValorServico { get; set; }       
        public decimal ValorCobradoAoCliente { get; set; }

        public int IdTipoEvento { get; set; }
        public string NomeEvento { get; set; }
        public int TotalConvidados { get; set; }               
        public decimal ValorTipoEvento { get; set; }
    }
}
