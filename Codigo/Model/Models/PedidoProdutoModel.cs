﻿using System;
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
        public int IdPedidoProduto { get; set; }

        public int IdPedido { get; set; }
        public string NomeCliente { get; set; }

        public string StatusPedido { get; set; }
        public DateTime DataCriacao { get; set; }
        
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public int? NumeroDePaginas { get; set; }
        public decimal ValorProduto { get; set; }
        public string Formato { get; set; }
        public int? NumeroDeImagens { get; set; }

        public int Quantidade { get; set; }
        
    }
}
