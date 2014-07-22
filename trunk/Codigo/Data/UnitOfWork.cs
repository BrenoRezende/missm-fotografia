﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;
using Model;

namespace Data
{
    /// <summary>
    /// UnitWork é um padrão de projeto que permite trabalhar 
    /// com vários repositórios compartilhando um mesmo contexto
    /// transacional
    /// </summary>
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private missmfotografiaEntities _context;
        private IRepositorioGenerico<tb_produto> _repProduto;
        private IRepositorioGenerico<tb_servico> _repServico;
        private IRepositorioGenerico<tb_tipo_evento> _repTipoEvento;
        private IRepositorioGenerico<tb_evento> _repEvento;
        private IRepositorioGenerico<tb_pedido> _repPedido;
        private IRepositorioGenerico<tb_pessoa> _repPessoa;
        private IRepositorioGenerico<tb_funcionario> _repFuncionario;

        


        public UnitOfWork()
        {
            _context = new Model.missmfotografiaEntities();
        }

        #region IUnitOfWork Members

        /// <summary>
        /// Repositório para manipular dados persistidos de Produtos
        /// </summary>
        public IRepositorioGenerico<tb_produto> RepositorioProduto
        {
            get
            {
                if (_repProduto == null)
                {
                    _repProduto = new RepositorioGenerico<tb_produto>(_context);
                }

                return _repProduto;
            }
        }

        /// <sumary>
        /// Repositório para manipular dados persistidos de pessoa
        /// </sumary>
        public IRepositorioGenerico<tb_pessoa> RepositorioPessoa
        {
            get
            {
                if (_repPessoa == null)
                {
                    _repPessoa = new RepositorioGenerico<tb_pessoa>(_context);
                }

                return _repPessoa;
            }
        }

        /// <sumary>
        /// Repositório para manipular dados persistidos de Funcionario
        /// </sumary>
        public IRepositorioGenerico<tb_funcionario> RepositorioFuncionario
        {
            get
            {
                if (_repFuncionario == null)
                {
                    _repFuncionario = new RepositorioGenerico<tb_funcionario>(_context);
                }

                return _repFuncionario;
            }
        }
        /// <summary>
        /// Repositório para manipular dados persistidos de Servico
        /// </summary>
        public IRepositorioGenerico<tb_servico> RepositorioServico
        {
            get
            {
                if (_repServico == null)
                {
                    _repServico = new RepositorioGenerico<tb_servico>(_context);
                }

                return _repServico;
            }
        }

        /// <summary>
        /// Repositório para manipular dados persistidos de TipoEvento
        /// </summary>
        public IRepositorioGenerico<tb_tipo_evento> RepositorioTipoEvento
        {
            get
            {
                if (_repTipoEvento == null)
                {
                    _repTipoEvento = new RepositorioGenerico<tb_tipo_evento>(_context);
                }

                return _repTipoEvento;
            }
        }


        /// <summary>
        /// Repositório para manipular dados persistidos de Evento
        /// </summary>
        public IRepositorioGenerico<tb_evento> RepositorioEvento
        {
            get 
            {
                if (_repEvento == null)
                {
                    _repEvento = new RepositorioGenerico<tb_evento>(_context);
                }
                return _repEvento;
            }
        }

        /// <sumary>
        /// Repositório para manipular dados persistidos de Pedido
        /// </sumary>
        public IRepositorioGenerico<tb_pedido> RepositorioPedido
        {
            get
            {
                if (_repPedido == null)
                {
                    _repPedido = new RepositorioGenerico<tb_pedido>(_context);
                }

                return _repPedido;
            }
        }



        /// <summary>
        /// Salva todas as mudanças realizadas no contexto
        /// quando o contexto não for compartilhado
        /// </summary>
        public void Commit(bool shared)
        {
            if (!shared)
                _context.SaveChanges();
        }

        #endregion

        private bool disposed = false;
        /// <summary>
        /// Retira da memória um determinado contexto
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        /// <summary>
        /// Limpa contexto da memória
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}