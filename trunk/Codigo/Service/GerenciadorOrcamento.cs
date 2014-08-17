using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Model.Models;
using Data;

namespace Service
{
  /**  public class GerenciadorOrcamento
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>

        public GerenciadorOrcamento()
        {
            this.unitOfWork = new UnitOfWork();
            this.shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="this.unitOfWork"></param>

        internal GerenciadorOrcamento(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.shared = true;
        }

          /// <summary>
        /// Consulta padrão para retornar dados do evento como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<OrcamentoModel> GetQueryProduto()
        {
            IQueryable<tb_produto> tb_produto = this.unitOfWork.RepositorioProduto.GetQueryable();
            var query = from produto in tb_produto
                        select new OrcamentoModel
                        {
                            IdProduto = produto.idProduto,
                            NomeProduto = produto.nomeProduto,
                            Formato = produto.formato,
                            NumeroDeImagens = produto.numeroDeImagens,
                            NumeroDePaginas = produto.numeroDePaginas,
                            ValorDoProduto = produto.valorDoProduto                            
                        };
            return query;
        }

        /// <summary>
        /// Consulta padrão para retornar dados do evento como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<OrcamentoModel> GetQueryServico()
        {
            IQueryable<tb_servico> tb_servico = this.unitOfWork.RepositorioServico.GetQueryable();
            var query = from servico in tb_servico
                        select new OrcamentoModel
                        {
                            IdServico = servico.idServico,
                            NomeServico = servico.nomeServico,
                            NomeParceiro = servico.nomeParceiro,
                            TelefoneParceiro = servico.telefoneParceiro,
                            ValorServico = servico.valorServico,
                            ValorCobradoAoCliente = servico.valorCobradoAoCliente
                        };
            return query;
        }

        private IQueryable<OrcamentoModel> GetQueryTiposDeEventos()
        {
            IQueryable<tb_tipo_evento> tb_tipo_evento = this.unitOfWork.RepositorioTipoEvento.GetQueryable();
            var query = from tipoEvento in tb_tipo_evento
                        select new OrcamentoModel
                        {
                            IdTipoEvento = tipoEvento.idTipoEvento,
                            NomeEvento = tipoEvento.nomeTipoEvento,
                            TotalConvidados = tipoEvento.totalConvidados,
                            ValorTipoEvento = tipoEvento.valorTipoEvento,                            
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades de produtos cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<OrcamentoModel> ObterTodosProdutos() 
        {
            return GetQueryProduto();
        }

        /// <summary>
        /// Obter todos as entidades de serviços cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<OrcamentoModel> ObterTodosServicos()
        {
            return GetQueryServico();
        }

        /// <summary>
        /// Obter todos as entidades de tipos de eventos cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<OrcamentoModel> ObterTodosTiposDeEvento()
        {
            return GetQueryTiposDeEventos();
        }
    }*/
}
