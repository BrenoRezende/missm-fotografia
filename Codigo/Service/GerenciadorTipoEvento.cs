﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Model.Models;
using Data;

namespace Service
{

    /// <summary>
    /// Gerencia todas as regras de negócio da entidade TipoEvento
    /// </summary>
    
    class GerenciadorTipoEvento
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
        
        public GerenciadorTipoEvento()
        {
            this.unitOfWork = new UnitOfWork;
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>
        
        internal GerenciadorTipoEvento(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="produtoModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(TipoEventoModel tipoEventoModel)
        {
            tb_tipo_evento tipoEventoE = new tb_tipo_evento();
            Atribuir(tipoEventoModel, tipoEventoE);
            unitOfWork.RepositorioTipoEvento.Inserir(tipoEventoE);
            unitOfWork.Commit(shared);
            return tipoEventoE.idTipoEvento;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="tipoEventoModel"></param>
        public void Editar(TipoEventoModel tipoEventoModel)
        {
            tb_tipo_evento tipoEventoE = new tb_tipo_evento();
            Atribuir(tipoEventoModel, tipoEventoE);
            unitOfWork.RepositorioTipoEvento.Editar(tipoEventoE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="idTipoEvento"></param>
        public void Remover(int idTipoEvento)
        {
            unitOfWork.RepositorioTipoEvento.Remover(tipoEvento => tipoEvento.idTipoEvento.Equals(idTipoEvento));
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Consulta padrão para retornar dados do tipo evento como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<TipoEventoModel> GetQuery()
        {
            IQueryable<tb_tipo_evento> tb_tipo_evento = unitOfWork.RepositorioTipoEvento.GetQueryable();
            var query = from tipoEvento in tb_tipo_evento
                        select new TipoEventoModel
                        {
                            IdTipoEvento = tipoEvento.idTipoEvento,
                            Nome = tipoEvento.nomeTipoEvento,
                            Categoria = tipoEvento.categoriaTipoEvento,
                            TotalConvidados = tipoEvento.totalConvidados,
                            Valor = tipoEvento.valorTipoEvento
                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TipoEventoModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um Tipo Evento
        /// </summary>
        /// <param name="idProduto">Identificador do tipo evento na base de dados</param>
        /// <returns>TipoEventoModel</returns>
        public TipoEventoModel Obter(int idTipoEvento)
        {
            IEnumerable<TipoEventoModel> tipo_evento = GetQuery().Where(tipoEventoModel => tipoEventoModel.IdTipoEvento.Equals(idTipoEvento));

            return tipo_evento.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Obtém um tipo evento pelo nome
        /// </summary>
        /// <param name="nome">Nome do tipo evento que será buscado base de dados</param>
        /// <returns>TipoEventoModel</returns>
        public IEnumerable<TipoEventoModel> ObterPorNome(string nome)
        {
            IEnumerable<TipoEventoModel> tipo_evento = GetQuery().Where(tipoEventoModel => tipoEventoModel.Nome.StartsWith(nome));
            return tipo_evento;
        }

        /// <summary>
        /// Atribui dados do TipoEventoModel para o TipoEvento Entity
        /// </summary>
        /// <param name="tipoEventoModel">Objeto do modelo</param>
        /// <param name="tipoEventoE">Entity mapeada da base de dados</param>
        private void Atribuir(TipoEventoModel tipoEventoModel, tb_tipo_evento tipoEventoE)
        {
            tipoEventoE.idTipoEvento = tipoEventoModel.IdTipoEvento;
            tipoEventoE.nomeTipoEvento = tipoEventoModel.Nome;
            tipoEventoE.categoriaTipoEvento = tipoEventoModel.Categoria;
            tipoEventoE.totalConvidados = tipoEventoModel.TotalConvidados;
            tipoEventoE.valorTipoEvento = tipoEventoModel.Valor;
        }
    }
}