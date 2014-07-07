using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Model.Models;
using Data;

namespace Service
{

    public class GerenciadorPedido
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>

        public GerenciadorPedido()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>

        internal GerenciadorPedido(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="pedidoModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(PedidoModel pedidoModel)
        {
            tb_pedido pedidoE = new tb_pedido();
            Atribuir(pedidoModel, pedidoE);
            unitOfWork.RepositorioPedido.Inserir(pedidoE);
            unitOfWork.Commit(shared);
            return pedidoE.idPedido;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="pedidoModel"></param>
        public void Editar(PedidoModel pedidoModel)
        {
            tb_pedido pedidoE = new tb_pedido();
            Atribuir(pedidoModel, pedidoE);
            unitOfWork.RepositorioPedido.Editar(pedidoE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="idPedido"></param>
        public void Remover(int idPedido)
        {
            unitOfWork.RepositorioPedido.Remover(pedido => pedido.idPedido.Equals(idPedido));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do pedido como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<PedidoModel> GetQuery()
        {
            IQueryable<tb_pedido> tb_pedido = unitOfWork.RepositorioPedido.GetQueryable();
            var query = from pedido in tb_pedido
                        select new PedidoModel
                        {
                            IdPedido = pedido.idPedido,
                            Nome = pedido.nomePedido,
                            DataCriacao = pedido.dataCriacao,
                            Valor = pedido.valorPedido,
                            StatusPedido = pedido.statusPedido,
                            DataEmissao = pedido.dataEmissao,
                            StatusContrato = pedido.statusContrato,
                            IdPessoa = pedido.idPessoa
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<PedidoModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um Pedido
        /// </summary>
        /// <param name="idPedido">Identificador do pedido na base de dados</param>
        /// <returns>PedidoModel</returns>
        public PedidoModel Obter(int idPedido)
        {
            IEnumerable<PedidoModel> pedidos = GetQuery().Where(pedidoModel => pedidoModel.IdPedido.Equals(idPedido));

            return pedidos.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Obtém um pedido pelo nome
        /// </summary>
        /// <param name="nome">Nome do pedido que será buscado base de dados</param>
        /// <returns>PedidoModel</returns>
        public IEnumerable<PedidoModel> ObterPorNome(string nome)
        {
            IEnumerable<PedidoModel> pedidos = GetQuery().Where(pedidoModel => pedidoModel.Nome.StartsWith(nome));
            return pedidos;
        }

        /// <summary>
        /// Atribui dados do PedidoModel para o Pedido Entity
        /// </summary>
        /// <param name="pedidoModel">Objeto do modelo</param>
        /// <param name="pedidoE">Entity mapeada da base de dados</param>
        private void Atribuir(PedidoModel pedidoModel, tb_pedido pedidoE)
        {
            //TODO: ligação com as outras tabelas
            pedidoE.idPedido = pedidoModel.IdPedido;
            pedidoE.nomePedido = pedidoModel.Nome;
            pedidoE.dataCriacao = pedidoModel.DataCriacao;
            pedidoE.valorPedido = pedidoModel.Valor;
            pedidoE.statusPedido = pedidoModel.StatusPedido;
            pedidoE.dataEmissao = pedidoModel.DataEmissao;
            pedidoE.statusContrato = pedidoModel.StatusContrato;
            pedidoE.idPessoa = pedidoModel.IdPessoa;
           // pedidoE.tb_produto.Add(new tb_produto.
        }
    }
}
