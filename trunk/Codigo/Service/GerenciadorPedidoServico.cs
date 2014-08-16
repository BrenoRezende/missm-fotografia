using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Model.Models;
using Data;

namespace Service
{
    public class GerenciadorPedidoServico
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorPedidoServico()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork">Interface que cria os repositórios</param>
        internal GerenciadorPedidoServico(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        public int Inserir(PedidoServicoModel pedidoServicoModel)
        {
            tb_pedido_tb_servico pedidoServicoE = new tb_pedido_tb_servico();
            Atribuir(pedidoServicoModel, pedidoServicoE);
            unitOfWork.RepositorioPedidoServico.Inserir(pedidoServicoE);
            unitOfWork.Commit(shared);
            return pedidoServicoE.idPedidoServico;
        }

        public void Editar(PedidoServicoModel pedidoServicoModel)
        {
            tb_pedido_tb_servico pedidoServicoE = new tb_pedido_tb_servico();
            Atribuir(pedidoServicoModel, pedidoServicoE);
            unitOfWork.RepositorioPedidoServico.Editar(pedidoServicoE);
            unitOfWork.Commit(shared);
        }

        public void Remover(int idPedidoServico)
        {
            unitOfWork.RepositorioPedidoProduto.Remover(pedidoServico => pedidoServico.idPedidoProduto.Equals(idPedidoServico));
            unitOfWork.Commit(shared);

        }

        private IQueryable<PedidoServicoModel> GetQuery()
        {
            IQueryable<tb_pedido_tb_servico> tb_pedido_servico = unitOfWork.RepositorioPedidoServico.GetQueryable();
            var query = from pedidoServico in tb_pedido_servico
                        orderby (pedidoServico.tb_servico.nomeServico)
                        select new PedidoServicoModel
                        {
                            IdPedidoServico = pedidoServico.idPedidoServico,
                            IdPedido = pedidoServico.idPedido,  
                            IdServico = pedidoServico.idServico,                           
                            Quantidade = pedidoServico.quantidade
                        };
            return query;
        }

        public IEnumerable<PedidoServicoModel> ObterTodos()
        {
            return GetQuery();
        }

        public PedidoServicoModel Obter(int idPedidoServico)
        {
            IEnumerable<PedidoServicoModel> pedidoServicos = GetQuery().Where(pedidoServicoModel => pedidoServicoModel.IdPedidoServico.Equals(idPedidoServico));
            return pedidoServicos.ElementAtOrDefault(0);
        }

        private void Atribuir(PedidoServicoModel pedidoServicoModel, tb_pedido_tb_servico pedidoServicoE)
        {
            pedidoServicoE.idPedidoServico = pedidoServicoModel.IdPedidoServico;
            pedidoServicoE.idServico = pedidoServicoModel.IdServico;
            pedidoServicoE.idPedido = pedidoServicoModel.IdPedido;            
            pedidoServicoE.quantidade = pedidoServicoModel.Quantidade;
        }
    }

}

