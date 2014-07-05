using System;
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
