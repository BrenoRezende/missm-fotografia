﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Model.Models;
using Data;

namespace Service
{

    public class GerenciadorEvento
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>

        public GerenciadorEvento()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>

        internal GerenciadorEvento(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="eventoModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(EventoModel eventoModel)
        {
            tb_evento eventoE = new tb_evento();
            Atribuir(eventoModel, eventoE);
            unitOfWork.RepositorioEvento.Inserir(eventoE);
            unitOfWork.Commit(shared);
            return eventoE.idEvento;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="eventoModel"></param>
        public void Editar(EventoModel eventoModel)
        {
            tb_evento eventoE = new tb_evento();
            Atribuir(eventoModel, eventoE);
            unitOfWork.RepositorioEvento.Editar(eventoE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="idEvento"></param>
        public void Remover(int idEvento)
        {
            unitOfWork.RepositorioEvento.Remover(evento => evento.idEvento.Equals(idEvento));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do evento como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<EventoModel> GetQuery()
        {
            IQueryable<tb_evento> tb_evento = unitOfWork.RepositorioEvento.GetQueryable();
            var query = from evento in tb_evento
                        select new EventoModel
                        {
                            IdEvento = evento.idEvento,
                            Nome = evento.nomeEvento,
                            Data = evento.dataEvento,
                            IdTipoEvento = evento.idTipoEvento,
                            NomeTipoEvento = evento.tb_tipo_evento.nomeTipoEvento
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<EventoModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obter todos as entidades cadastradas em Tipo Evento
        /// </summary>
        /// <returns></returns>
        public IEnumerable<EventoModel> ObterTodosPorTipoEvento(int idTipoEvento)
        {
            return GetQuery().Where(evento => evento.IdTipoEvento.Equals(idTipoEvento));
        }

        /// <summary>
        /// Obtém um Evento
        /// </summary>
        /// <param name="idEvento">Identificador do evento na base de dados</param>
        /// <returns>EventoModel</returns>
        public EventoModel Obter(int idEvento)
        {
            IEnumerable<EventoModel> eventos = GetQuery().Where(eventoModel => eventoModel.IdEvento.Equals(idEvento));

            return eventos.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Obtém um evento pelo nome
        /// </summary>
        /// <param name="nome">Nome do evento que será buscado base de dados</param>
        /// <returns>EventoModel</returns>
        public IEnumerable<EventoModel> ObterPorNome(string nome)
        {
            IEnumerable<EventoModel> eventos = GetQuery().Where(eventoModel => eventoModel.Nome.StartsWith(nome));
            return eventos;
        }

        /// <summary>
        /// Atribui dados do EventoModel para o Evento Entity
        /// </summary>
        /// <param name="eventoModel">Objeto do modelo</param>
        /// <param name="eventoE">Entity mapeada da base de dados</param>
        private void Atribuir(EventoModel eventoModel, tb_evento eventoE)
        {
            eventoE.idEvento = eventoModel.IdEvento;
            eventoE.nomeEvento = eventoModel.Nome;
            eventoE.dataEvento = eventoModel.Data;
            eventoE.idTipoEvento = eventoModel.IdTipoEvento;
        }
    }
}
