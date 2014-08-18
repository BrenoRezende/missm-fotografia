using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Model.Models;
using Data;

namespace Service
{
    public class GerenciadorPedidoProduto
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorPedidoProduto()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork">Interface que cria os repositórios</param>
        internal GerenciadorPedidoProduto(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        public int Inserir(PedidoProdutoModel pedidoProdutoModel)
        {
            tb_pedido_tb_produto pedidoProdutoE = new tb_pedido_tb_produto();
            Atribuir(pedidoProdutoModel, pedidoProdutoE);
            unitOfWork.RepositorioPedidoProduto.Inserir(pedidoProdutoE);
            unitOfWork.Commit(shared);
            return pedidoProdutoE.idPedidoProduto;
        }

        public void Editar(PedidoProdutoModel pedidoProdutoModel)
        {
            tb_pedido_tb_produto pedidoProdutoE = new tb_pedido_tb_produto();
            Atribuir(pedidoProdutoModel, pedidoProdutoE);
            unitOfWork.RepositorioPedidoProduto.Editar(pedidoProdutoE);
            unitOfWork.Commit(shared);
        }

        public void Remover(int idPedido)
        {
            unitOfWork.RepositorioPedidoProduto.Remover(pedidoProduto => pedidoProduto.idPedido.Equals(idPedido));
            unitOfWork.Commit(shared);

        }

        private IQueryable<PedidoProdutoModel> GetQuery()
        {
            IQueryable<tb_pedido_tb_produto> tb_pedido_produto = unitOfWork.RepositorioPedidoProduto.GetQueryable();
            var query = from pedidoProduto in tb_pedido_produto
                        orderby (pedidoProduto.tb_produto.nomeProduto)
                        select new PedidoProdutoModel
                        {
                            IdPedidoProduto = pedidoProduto.idPedidoProduto,                            
                            IdPedido = pedidoProduto.idPedido,                                      
                            IdProduto = pedidoProduto.idProduto,                               
                        };
            return query;
        }

        public IEnumerable<PedidoProdutoModel> ObterTodos()
        {
            return GetQuery();
        }

        public PedidoProdutoModel Obter(int idPedidoProduto)
        {
            IEnumerable<PedidoProdutoModel> pedidoProdutos = GetQuery().Where(pedidoProdutoModel => pedidoProdutoModel.IdPedidoProduto.Equals(idPedidoProduto));
            return pedidoProdutos.ElementAtOrDefault(0);
        }

        public IEnumerable<PedidoProdutoModel> ObterPorOrcamento(int idPedido)
        {
            IEnumerable<PedidoProdutoModel> pedidoProdutos = GetQuery().Where(pedidoProdutoModel => pedidoProdutoModel.IdPedido.Equals(idPedido));
            return pedidoProdutos;
        }

        public IEnumerable<ProdutoModel> ObterProdutosDoOrcamento(int idPedido)
        {
            IQueryable<tb_pedido_tb_produto> tb_pedido_produto = unitOfWork.RepositorioPedidoProduto.GetQueryable();
            IQueryable<tb_produto> tb_produto = unitOfWork.RepositorioProduto.GetQueryable();

            var query = from pedido in tb_pedido_produto
                        join produto in tb_produto
                        on pedido.idProduto equals produto.idProduto
                      
                        select new ProdutoModel
                        {
                            Nome = produto.nomeProduto,
                            NumeroDePaginas = produto.numeroDePaginas,
                            NumeroDeImagens = produto.numeroDeImagens,
                            Formato = produto.formato,
                            ValorDoProduto = produto.valorDoProduto
                        };
            return query;
        
        }

        private void Atribuir(PedidoProdutoModel pedidoProdutoModel, tb_pedido_tb_produto pedidoProdutoE)
        {
            pedidoProdutoE.idPedidoProduto = pedidoProdutoModel.IdPedidoProduto;
            pedidoProdutoE.idProduto = pedidoProdutoModel.IdProduto;
            pedidoProdutoE.idPedido = pedidoProdutoModel.IdPedido;     
        }
    }
    
}

