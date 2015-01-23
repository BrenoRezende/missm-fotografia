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
            this.shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="this.unitOfWork"></param>

        internal GerenciadorServico(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.shared = true;
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
            this.unitOfWork.RepositorioServico.Inserir(servicoE);
            this.unitOfWork.Commit(this.shared);
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
            this.unitOfWork.RepositorioServico.Editar(servicoE);
            this.unitOfWork.Commit(this.shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="idServico"></param>
        public void Remover(int idServico)
        {
            this.unitOfWork.RepositorioServico.Remover(servico => servico.idServico.Equals(idServico));
            this.unitOfWork.Commit(this.shared);
        }

        /// <summary>
        /// Consulta padrão para retornar dados do servico como model
        /// </summary>
        /// <returns></returns>

        private IQueryable<ServicoModel> GetQuery()
        {
            IQueryable<tb_servico> tb_servico = this.unitOfWork.RepositorioServico.GetQueryable();
            var query = from servico in tb_servico
                        select new ServicoModel
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

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ServicoModel> ObterTodos()
        {
            return this.GetQuery();
        }

        /// <summary>
        /// Obtém um Servico
        /// </summary>
        /// <param name="idServico">Identificador do servico na base de dados</param>
        /// <returns>ServicoModel</returns>
        public ServicoModel Obter(int idServico)
        {
            IEnumerable<ServicoModel> servicos = this.GetQuery().Where(servicoModel => servicoModel.IdServico.Equals(idServico));

            return servicos.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Obtém um serviço pelo nome
        /// </summary>
        /// <param name="nome">Nome do serviço que será buscado base de dados</param>
        /// <returns>ServicoModel</returns>
        public IEnumerable<ServicoModel> ObterPorNome(string nome)
        {
            IEnumerable<ServicoModel> servicos = this.GetQuery().Where(servicoModel => servicoModel.NomeServico.StartsWith(nome));
            return servicos;
        }


        /// <summary>
        /// Atribui dados do ServicoModel para o Servico Entity
        /// </summary>
        /// <param name="servicoModel">Objeto do modelo</param>
        /// <param name="servicoE">Entity mapeada da base de dados</param>
        private void Atribuir(ServicoModel servicoModel, tb_servico servicoE)
        {
            servicoE.idServico = servicoModel.IdServico;
            servicoE.nomeServico = servicoModel.NomeServico;
            servicoE.nomeParceiro = servicoModel.NomeParceiro;
            servicoE.telefoneParceiro = servicoModel.TelefoneParceiro;
            servicoE.valorServico = servicoModel.ValorServico;
            servicoE.valorCobradoAoCliente = servicoModel.ValorCobradoAoCliente;

        }

    }
}
