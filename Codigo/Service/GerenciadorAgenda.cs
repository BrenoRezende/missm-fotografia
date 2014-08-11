using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Model.Models;
using Data;

namespace Service
{

    public class GerenciadorAgenda
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>

        public GerenciadorAgenda()
        {
            this.unitOfWork = new UnitOfWork();
            this.shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>

        internal GerenciadorAgenda(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="agendaModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(AgendaModel agendaModel)
        {
            tb_agenda agendaE = new tb_agenda();
            Atribuir(agendaModel, agendaE);
            this.unitOfWork.RepositorioAgenda.Inserir(agendaE);
            this.unitOfWork.Commit(this.shared);
            return agendaE.idAgenda;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="agendaModel"></param>
        public void Editar(AgendaModel agendaModel)
        {
            tb_agenda agendaE = new tb_agenda();
            Atribuir(agendaModel, agendaE);
            this.unitOfWork.RepositorioAgenda.Editar(agendaE);
            this.unitOfWork.Commit(this.shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="idAgenda"></param>
        public void Remover(int idAgenda)
        {
            this.unitOfWork.RepositorioAgenda.Remover(agenda => agenda.idAgenda.Equals(idAgenda));
            this.unitOfWork.Commit(this.shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do agenda como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<AgendaModel> GetQuery()
        {
            IQueryable<tb_agenda> tb_agenda = this.unitOfWork.RepositorioAgenda.GetQueryable();
            var query = from agenda in tb_agenda
                        select new AgendaModel
                        {
                            IdAgenda = agenda.idAgenda,
                            Nome = agenda.nomeAtividade,
                            Descricao = agenda.descricaoAtividade,
                            Data = agenda.dataAtividade,
                            Status = agenda.status,
                            IdUsers = agenda.idUsers
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AgendaModel> ObterTodos()
        {
            return this.GetQuery();
        }


        /// <summary>
        /// Obtém um Agenda
        /// </summary>
        /// <param name="idAgenda">Identificador do agenda na base de dados</param>
        /// <returns>AgendaModel</returns>
        public AgendaModel Obter(int idAgenda)
        {
            IEnumerable<AgendaModel> agendas = this.GetQuery().Where(agendaModel => agendaModel.IdAgenda.Equals(idAgenda));

            return agendas.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Obtém um agenda pelo nome
        /// </summary>
        /// <param name="nome">Nome do agenda que será buscado base de dados</param>
        /// <returns>AgendaModel</returns>
        public IEnumerable<AgendaModel> ObterPorUsuario(int idUser)
        {
            IEnumerable<AgendaModel> agendas = this.GetQuery().Where(agendaModel => agendaModel.IdUsers.Equals(idUser));
            return agendas;
        }

        /// <summary>
        /// Atribui dados do AgendaModel para o Agenda Entity
        /// </summary>
        /// <param name="agendaModel">Objeto do modelo</param>
        /// <param name="agendaE">Entity mapeada da base de dados</param>
        private void Atribuir(AgendaModel agendaModel, tb_agenda agendaE)
        {
            agendaE.idAgenda = agendaModel.IdAgenda;
            agendaE.nomeAtividade = agendaModel.Nome;
            agendaE.descricaoAtividade = agendaModel.Descricao;
            agendaE.dataAtividade = agendaModel.Data;
            agendaE.status = agendaModel.Status;
            agendaE.idUsers = agendaModel.IdUsers;
        }
    }
}
