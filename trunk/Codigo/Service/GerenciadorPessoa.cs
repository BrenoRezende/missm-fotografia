using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Model.Models;
using Data;


namespace Service
{
    public class GerenciadorPessoa
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>

        public GerenciadorPessoa()
        {
            this.unitOfWork = new UnitOfWork();
            this.shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>

        internal GerenciadorPessoa(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="pessoaModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>

        public int Inserir(PessoaModel pessoaModel)
        {
            pessoaModel.TipoPessoa = "C";
            tb_pessoa pessoaE = new tb_pessoa();
            Atribuir(pessoaModel, pessoaE);
            this.unitOfWork.RepositorioPessoa.Inserir(pessoaE);
            this.unitOfWork.Commit(this.shared);
            return pessoaE.idPessoa;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="pessoaModel"></param>
        public void Editar(PessoaModel pessoaModel)
        {
            tb_pessoa pessoaE = new tb_pessoa();
            Atribuir(pessoaModel, pessoaE);
            this.unitOfWork.RepositorioPessoa.Editar(pessoaE);
            this.unitOfWork.Commit(this.shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="idPessoa"></param>
        public void Remover(int idPessoa)
        {
            this.unitOfWork.RepositorioPessoa.Remover(pessoa => pessoa.idPessoa.Equals(idPessoa));
            this.unitOfWork.Commit(this.shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados de pessoa como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<PessoaModel> GetQuery()
        {
            IQueryable<tb_pessoa> tb_pessoa = this.unitOfWork.RepositorioPessoa.GetQueryable();
            var query = from pessoa in tb_pessoa  where pessoa.tipoPessoa.Equals("C")                                             
                        select new PessoaModel
                        {
                            IdPessoa = pessoa.idPessoa,
                            Nome = pessoa.nomePessoa,
                            Cpf = pessoa.cpfPessoa,
                            Sexo = pessoa.sexoPessoa,
                            DataNascimento = pessoa.dataNascimentoPessoa,
                            Telefone = pessoa.telefonePessoa,
                            Email = pessoa.emailPessoa,
                            Senha = pessoa.senhaPessoa,
                            Rua = pessoa.rua,
                            Numero = pessoa.numero,
                            Bairro = pessoa.bairro,
                            Cidade = pessoa.cidade,
                            Estado = pessoa.estado,
                            TipoPessoa = pessoa.tipoPessoa
                        };
            return query;
        }

        /// <summary>
        /// Obtém uma Pessoa
        /// </summary>
        /// <param name="idPessoa">Identificador da pessoa na base de dados</param>
        /// <returns>PessoaModel</returns>
        public PessoaModel Obter(int idPessoa)
        {
            IEnumerable<PessoaModel> pessoas = this.GetQuery().Where(pessoasModel => pessoasModel.IdPessoa.Equals(idPessoa));

            return pessoas.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Obtém uma pessoa pelo nome
        /// </summary>
        /// <param name="nome">Nome da pessoa que será buscado base de dados</param>
        /// <returns>PessoaModel</returns>
        public IEnumerable<PessoaModel> ObterPorNome(string nome)
        {
            IEnumerable<PessoaModel> pessoas = this.GetQuery().Where(pessoaModel => pessoaModel.Nome.StartsWith(nome));
            return pessoas;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<PessoaModel> ObterTodos()
        {
            return this.GetQuery();
        }

        /// <summary>
        /// Atribui dados de PessoaModel para Pessoa Entity
        /// </summary>
        /// <param name="pessoaModel">Objeto do modelo</param>
        /// <param name="pessoaE">Entity mapeada da base de dados</param>
        private void Atribuir(PessoaModel pessoaModel, tb_pessoa pessoaE)
        {
            pessoaE.idPessoa = pessoaModel.IdPessoa;
            pessoaE.nomePessoa = pessoaModel.Nome;
            pessoaE.cpfPessoa = pessoaModel.Cpf;
            pessoaE.sexoPessoa = pessoaModel.Sexo;
            pessoaE.dataNascimentoPessoa = pessoaModel.DataNascimento;
            pessoaE.telefonePessoa = pessoaModel.Telefone;
            pessoaE.emailPessoa = pessoaModel.Email;
            pessoaE.senhaPessoa = pessoaModel.Senha;
            pessoaE.rua = pessoaModel.Rua;
            pessoaE.numero = pessoaModel.Numero;
            pessoaE.bairro = pessoaModel.Bairro;
            pessoaE.cidade = pessoaModel.Cidade;
            pessoaE.estado = pessoaModel.Estado;
            pessoaE.tipoPessoa = pessoaModel.TipoPessoa ;
        }
    }
}
