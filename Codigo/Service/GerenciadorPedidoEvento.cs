using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Model.Models;
using Data;

namespace Service
{
    public class GerenciadorPedidoEvento
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        public GerenciadorPedidoEvento()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork">Interface que cria os repositórios</param>
        internal GerenciadorPedidoEvento(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        public int Inserir(PedidoEventoModel pedidoEventoModel)
        {
            tb_pedido_tb_evento pedidoEventoE = new tb_pedido_tb_evento();
            Atribuir(pedidoEventoModel, pedidoEventoE);
            unitOfWork.RepositorioPedidoEvento.Inserir(pedidoEventoE);
            unitOfWork.Commit(shared);
            return pedidoEventoE.idPedidoEvento;
        }

        public void Editar(PedidoEventoModel pedidoEventoModel)
        {
            tb_pedido_tb_evento pedidoEventoE = new tb_pedido_tb_evento();
            Atribuir(pedidoEventoModel, pedidoEventoE);
            unitOfWork.RepositorioPedidoEvento.Editar(pedidoEventoE);
            unitOfWork.Commit(shared);
        }

        public void Remover(int idPedido)
        {
            unitOfWork.RepositorioPedidoEvento.Remover(pedidoEvento => pedidoEvento.idPedido.Equals(idPedido));
            unitOfWork.Commit(shared);
        }

        private IQueryable<PedidoEventoModel> GetQuery()
        {
            IQueryable<tb_pedido_tb_evento> tb_pedido_evento = unitOfWork.RepositorioPedidoEvento.GetQueryable();
            var query = from pedidoEvento in tb_pedido_evento
                        orderby (pedidoEvento.tb_tipo_evento.nomeTipoEvento)
                        select new PedidoEventoModel
                        {
                            IdPedidoEvento = pedidoEvento.idPedidoEvento,
                            IdPedido = pedidoEvento.idPedido,                
                            IdTipoEvento = pedidoEvento.idTipoEvento                          
                        };
            return query;
        }

        public IEnumerable<PedidoEventoModel> ObterTodos()
        {
            return GetQuery();
        }

        public PedidoEventoModel Obter(int idPedidoEvento)
        {
            IEnumerable<PedidoEventoModel> pedidoEventos = GetQuery().Where(pedidoEventoModel => pedidoEventoModel.IdPedidoEvento.Equals(idPedidoEvento));
            return pedidoEventos.ElementAtOrDefault(0);
        }

        private void Atribuir(PedidoEventoModel pedidoEventoModel, tb_pedido_tb_evento pedidoEventoE)
        {
            pedidoEventoE.idPedidoEvento = pedidoEventoModel.IdPedidoEvento;
            pedidoEventoE.idTipoEvento = pedidoEventoModel.IdTipoEvento;
            pedidoEventoE.idPedido = pedidoEventoModel.IdPedido;           
        }
    }
}
