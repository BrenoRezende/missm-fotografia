using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Model.Models;
using Data;

namespace Service
{
    public class GerenciadorServico
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Gerencia todas as regras de negócio da entidade Produto
        /// </summary>

        public GerenciadorServico()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>

        internal GerenciadorServico(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="servicoModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>

        public int Inserir(ServicoModel servicoModel)
        {
            tb_servico servicoE = new tb_servico();
            Atribuir(servicoModel, servicoE);
            unitOfWork.RepositorioServico.Inserir(servicoE);
            unitOfWork.Commit(shared);
            return servicoE.idServico;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="servicoModel"></param>

        public void Editar(ServicoModel servicoModel)
        {
            tb_servico servicoE = new tb_servico();
            Atribuir(servicoModel, servicoE);
            unitOfWork.RepositorioServico.Editar(servicoE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="idServico"></param>
        public void Remover(int idServico)
        {
            unitOfWork.RepositorioServico.Remover(servico => servico.idServico.Equals(idServico));
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Consulta padrão para retornar dados do servico como model
        /// </summary>
        /// <returns></returns>

        private IQueryable<ServicoModel> GetQuery()
        {
            IQueryable<tb_servico> tb_servico = unitOfWork.RepositorioServico.GetQueryable();
            var query = from servico in tb_servico
                        select new ServicoModel
                        {
                            IdServico = servico.idServico,
                            TipoServico = servico.tipoServico,
                            Parceiro = servico.parceiro,
                            TelefoneParceiro = servico.telefoneParceiro,
                            ValorServico = servico.valorServico,
                            ValorCobradoAoCliente = servico.valorCobradoAoCliente
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ServicoModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um Servico
        /// </summary>
        /// <param name="idServico">Identificador do servico na base de dados</param>
        /// <returns>ServicoModel</returns>
        public ServicoModel Obter(int idServico)
        {
            IEnumerable<ServicoModel> servicos = GetQuery().Where(servicoModel => servicoModel.IdServico.Equals(idServico));

            return servicos.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Atribui dados do ServicoModel para o Servico Entity
        /// </summary>
        /// <param name="servicoModel">Objeto do modelo</param>
        /// <param name="servicoE">Entity mapeada da base de dados</param>
        private void Atribuir(ServicoModel servicoModel, tb_servico servicoE)
        {
            servicoE.idServico = servicoModel.IdServico;
            servicoE.tipoServico = servicoModel.TipoServico;
            servicoE.parceiro = servicoModel.Parceiro;
            servicoE.telefoneParceiro = servicoModel.TelefoneParceiro;
            servicoE.valorServico = servicoModel.ValorServico;
            servicoE.valorCobradoAoCliente = servicoModel.ValorCobradoAoCliente;

        }

    }
}
