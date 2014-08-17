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
        public ProdutoModel Produto { get; set; }
        public List<ProdutoModel> ListaProdutos { get; set; }

        public ServicoModel Servico { get; set; }
        public List<ServicoModel> ListaServico { get; set; }

        public TipoEventoModel TipoEvento { get; set; }
        public List<TipoEventoModel> ListaTipoEvento { get; set; }
    }
}
