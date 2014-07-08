﻿using System;
using Data;
using Model;

namespace Data
{
    public interface IUnitOfWork
    {
        void Commit(bool shared);
        IRepositorioGenerico<tb_produto> RepositorioProduto { get; }

        IRepositorioGenerico<tb_servico> RepositorioServico { get; }

        IRepositorioGenerico<tb_tipo_evento> RepositorioTipoEvento { get; }

        IRepositorioGenerico<tb_pedido> RepositorioPedido { get; }

        IRepositorioGenerico<tb_pessoa> RepositorioCliente { get; }
    }
}