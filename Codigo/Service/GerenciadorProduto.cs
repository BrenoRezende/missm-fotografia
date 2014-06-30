using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Model.Models;
using Data;

namespace Service
{

    /// <summary>
    /// Gerencia todas as regras de negócio da entidade Produto
    /// </summary>
   
    public class GerenciadorProduto
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
         
        public GerenciadorProduto()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>
        
        internal GerenciadorProduto(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="produtoModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(ProdutoModel produtoModel)
        {
            tb_produto produtoE = new tb_produto();
            Atribuir(produtoModel, produtoE);
            unitOfWork.RepositorioProduto.Inserir(produtoE);
            unitOfWork.Commit(shared);
            return produtoE.idProduto;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="produtoModel"></param>
        public void Editar(ProdutoModel produtoModel)
        {
            tb_produto produtoE = new tb_produto();
            Atribuir(produtoModel, produtoE);
            unitOfWork.RepositorioProduto.Editar(produtoE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="idProduto"></param>
        public void Remover(int idProduto)
        {
            unitOfWork.RepositorioProduto.Remover(produto => produto.idProduto.Equals(idProduto));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do produto como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<ProdutoModel> GetQuery()
        {
            IQueryable<tb_produto> tb_produto = unitOfWork.RepositorioProduto.GetQueryable();
            var query = from produto in tb_produto
                        select new ProdutoModel
                        {
                            IdProduto = produto.idProduto,
                            NomeProduto = produto.nomeProduto,
                            NumeroDePaginas = produto.numeroDePaginas,
                            Formato = produto.formato,
                            NumeroDeImagens = produto.numeroDeImagens,
                            ValorDoProduto = produto.valorDoProduto,
                            ValorImagemAdicional = produto.valorImagemAdicional

                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ProdutoModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Obtém um Produto
        /// </summary>
        /// <param name="idProduto">Identificador do produto na base de dados</param>
        /// <returns>ProdutoModel</returns>
        public ProdutoModel Obter(int idProduto)
        {
            IEnumerable<ProdutoModel> produtos = GetQuery().Where(produtoModel => produtoModel.IdProduto.Equals(idProduto));

            return produtos.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Obtém um produto pelo nome
        /// </summary>
        /// <param name="nome">Nome do produto que será buscado base de dados</param>
        /// <returns>ProdutoModel</returns>
        public IEnumerable<ProdutoModel> ObterPorNome(string nome)
        {
            IEnumerable<ProdutoModel> produtos = GetQuery().Where(produtoModel => produtoModel.NomeProduto.StartsWith(nome));
            return produtos;
        }

        /// <summary>
        /// Atribui dados do ProdutoModel para o Produto Entity
        /// </summary>
        /// <param name="produtoModel">Objeto do modelo</param>
        /// <param name="produtoE">Entity mapeada da base de dados</param>
        private void Atribuir(ProdutoModel produtoModel, tb_produto produtoE)
        {
            produtoE.idProduto = produtoModel.IdProduto;
            produtoE.nomeProduto = produtoModel.NomeProduto;
            produtoE.numeroDePaginas = produtoModel.NumeroDePaginas;
            produtoE.formato = produtoModel.Formato;
            produtoE.numeroDeImagens = produtoModel.NumeroDeImagens;
            produtoE.valorDoProduto = produtoModel.ValorDoProduto;
            produtoE.valorImagemAdicional = produtoModel.ValorImagemAdicional;
        }
    }
}
