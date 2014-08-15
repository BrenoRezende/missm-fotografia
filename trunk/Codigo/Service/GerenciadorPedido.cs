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
            this.shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="this.unitOfWork"></param>

        internal GerenciadorPedido(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.shared = true;
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
            this.unitOfWork.RepositorioPedido.Inserir(pedidoE);
            this.unitOfWork.Commit(this.shared);
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
            this.unitOfWork.RepositorioPedido.Inserir(pedidoE);
            this.unitOfWork.Commit(this.shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="idPedido"></param>
        public void Remover(int idPedido)
        {
            this.unitOfWork.RepositorioPedido.Remover(pedido => pedido.idPedido.Equals(idPedido));
            this.unitOfWork.Commit(this.shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do evento como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<PedidoModel> GetQuery()
        {
            IQueryable<tb_pedido> tb_pedido = this.unitOfWork.RepositorioPedido.GetQueryable();
            var query = from pedido in tb_pedido
                        select new PedidoModel
                        {
                            IdPedido = pedido.idPedido,
                            NomePedido = pedido.nomePedido,
                            DataCriacao = pedido.dataCriacao,
                            Valor = pedido.valorPedido,
                            StatusPedido = pedido.statusPedido,
                            DataEmissao = pedido.dataEmissao,
                            StatusContrato = pedido.statusContrato,
                            IdPessoa = pedido.idPessoa,
                            NomePessoa = pedido.tb_pessoa.nomePessoa
                        };
            return query;
        }       
        

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<PedidoModel> ObterTodos()
        {
            return this.GetQuery();
        }

         /// <summary>
        /// Obtém um Evento
        /// </summary>
        /// <param name="idPedido">Identificador do evento na base de dados</param>
        /// <returns>PedidoModel</returns>
        public PedidoModel Obter(int idPedido)
        {
            IEnumerable<PedidoModel> pedidos = this.GetQuery().Where(pedidoModel => pedidoModel.IdPedido.Equals(idPedido));

            return pedidos.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Obtém um evento pelo nome
        /// </summary>
        /// <param name="nome">Nome do evento que será buscado base de dados</param>
        /// <returns>EventoModel</returns>
        public IEnumerable<PedidoModel> ObterPorNome(string nome)
        {
            IEnumerable<PedidoModel> eventos = this.GetQuery().Where(eventoModel => eventoModel.NomePedido.StartsWith(nome));
            return eventos;
        }

        /// <summary>
        /// Atribui dados do EventoModel para o Evento Entity
        /// </summary>
        /// <param name="pedidoModel">Objeto do modelo</param>
        /// <param name="pedidoE">Entity mapeada da base de dados</param>
        private void Atribuir(PedidoModel pedidoModel, tb_pedido pedidoE)
        {
            pedidoE.idPedido = pedidoModel.IdPedido;
            pedidoE.nomePedido = pedidoModel.NomePedido;
            pedidoE.dataCriacao = DateTime.Now;
            pedidoE.valorPedido = pedidoModel.Valor;
            pedidoE.statusPedido = pedidoModel.StatusPedido;
            pedidoE.dataEmissao = pedidoModel.DataEmissao;
            pedidoE.statusContrato = pedidoModel.StatusContrato;
            pedidoE.idPessoa = pedidoModel.IdPessoa;          
            
        }
    }
}
    