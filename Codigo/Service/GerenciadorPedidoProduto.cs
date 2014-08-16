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

        public void Remover(int idPedidoProduto)
        {
            unitOfWork.RepositorioPedidoProduto.Remover(pedidoProduto => pedidoProduto.idPedidoProduto.Equals(idPedidoProduto));
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
                            Quantidade = pedidoProduto.quantidade
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

        private void Atribuir(PedidoProdutoModel pedidoProdutoModel, tb_pedido_tb_produto pedidoProdutoE)
        {
            pedidoProdutoE.idPedidoProduto = pedidoProdutoModel.IdPedidoProduto;
            pedidoProdutoE.idProduto = pedidoProdutoModel.IdProduto;
            pedidoProdutoE.idPedido = pedidoProdutoModel.IdPedido;    
            pedidoProdutoE.quantidade = pedidoProdutoModel.Quantidade;  
        }
    }
    
}

