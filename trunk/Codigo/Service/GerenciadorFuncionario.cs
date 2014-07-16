using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Model.Models;
using Data;

namespace Service
{

    public class GerenciadorFuncionario
    {
        private GerenciadorPessoa gPessoa;

        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>

        public GerenciadorFuncionario()
        {
            this.unitOfWork = new UnitOfWork();
            this.shared = false;
            gPessoa = new GerenciadorPessoa(unitOfWork);
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="this.unitOfWork"></param>

        internal GerenciadorFuncionario(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            this.shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="funcionarioModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>
        public int Inserir(FuncionarioModel funcionarioModel)
        {                   
            funcionarioModel.IdPessoa = new GerenciadorPessoa().InserirFuncionario(new PessoaModel() {
                IdPessoa = funcionarioModel.IdPessoa,
                Nome = funcionarioModel.Nome,
                Cpf = funcionarioModel.Cpf,
                Sexo = funcionarioModel.Sexo,
                DataNascimento = funcionarioModel.DataNascimento,
                Telefone = funcionarioModel.Telefone,
                Email = funcionarioModel.Email,
                Senha = funcionarioModel.Senha,
                Rua = funcionarioModel.Rua,
                Numero = funcionarioModel.Numero,
                Bairro = funcionarioModel.Bairro,
                Cidade = funcionarioModel.Cidade,
                Estado = funcionarioModel.Estado,
                TipoPessoa = funcionarioModel.TipoPessoa
            });

            tb_funcionario funcionarioE = new tb_funcionario();

            Atribuir(funcionarioModel, funcionarioE);
            this.unitOfWork.RepositorioFuncionario.Inserir(funcionarioE);
            this.unitOfWork.Commit(this.shared);
            return funcionarioE.idFuncionario;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="funcionarioModel"></param>
        public void Editar(FuncionarioModel funcionarioModel)
        {
            
            tb_funcionario funcionarioE = new tb_funcionario();            
            Atribuir(funcionarioModel, funcionarioE);
            this.unitOfWork.RepositorioFuncionario.Editar(funcionarioE);
            tb_pessoa pessoaE = new tb_pessoa();
            gPessoa.EditarFuncionario(funcionarioModel);
            this.unitOfWork.Commit(this.shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="idPessoa da tabela tb_funcionario"></param>
        public void Remover(int idFuncionario)        {            
            this.unitOfWork.RepositorioFuncionario.Remover(funcionario => funcionario.idPessoa.Equals(idFuncionario));
            this.unitOfWork.RepositorioPessoa.Remover(funcionario => funcionario.idPessoa.Equals(idFuncionario));
            this.unitOfWork.Commit(this.shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do funcionario como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<FuncionarioModel> GetQuery()
        {
            IQueryable<tb_funcionario> tb_funcionario = this.unitOfWork.RepositorioFuncionario.GetQueryable();
            IQueryable<tb_pessoa> tb_pessoa = this.unitOfWork.RepositorioPessoa.GetQueryable();

            

            var query = from funcionario in tb_funcionario 
                        join pessoa in tb_pessoa
                        on funcionario.idPessoa equals pessoa.idPessoa  
                        select new FuncionarioModel
                        {
                           
                            IdFuncionario = funcionario.idFuncionario,
                            TipoConta = funcionario.tipoConta,
                            Banco = funcionario.banco,
                            Agencia = funcionario.agencia,
                            NumeroConta = funcionario.numeroConta,

                            IdPessoa = funcionario.idPessoa,
                            Nome = funcionario.tb_pessoa.nomePessoa,
                            Cpf = funcionario.tb_pessoa.cpfPessoa,
                            Sexo = funcionario.tb_pessoa.sexoPessoa,
                            DataNascimento = funcionario.tb_pessoa.dataNascimentoPessoa,
                            Telefone = funcionario.tb_pessoa.telefonePessoa,
                            Email = funcionario.tb_pessoa.emailPessoa,
                            Senha = funcionario.tb_pessoa.senhaPessoa,
                            Rua = funcionario.tb_pessoa.rua,
                            Numero = funcionario.tb_pessoa.numero,
                            Bairro = funcionario.tb_pessoa.bairro,
                            Cidade = funcionario.tb_pessoa.cidade,
                            Estado = funcionario.tb_pessoa.estado,
                            TipoPessoa = funcionario.tb_pessoa.tipoPessoa

                        };
            return query;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<FuncionarioModel> ObterTodos()
        {
            return this.GetQuery();
        }

        /// <summary>
        /// Obtém um Funcionario
        /// </summary>
        /// <param name="idFuncionario">Identificador do funcionario na base de dados</param>
        /// <returns>FuncionarioModel</returns>
        public FuncionarioModel Obter(int idFuncionario)
        {
            IEnumerable<FuncionarioModel> funcionarios = this.GetQuery().Where(funcionarioModels => funcionarioModels.IdPessoa.Equals(idFuncionario));

            return funcionarios.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Obtém um evento pelo nome
        /// </summary>
        /// <param name="nome">Nome do evento que será buscado base de dados</param>
        /// <returns>EventoModel</returns>
        public IEnumerable<FuncionarioModel> ObterPorNome(string nome)
        {
            IEnumerable<FuncionarioModel> funcionarios = this.GetQuery().Where(funcionarioModel => funcionarioModel.Nome.StartsWith(nome));
            return funcionarios;
        }

        /// <summary>
        /// Atribui dados do FuncionarioModel para o Funcionario Entity
        /// </summary>
        /// <param name="funcionarioModel">Objeto do modelo</param>
        /// <param name="funcionarioE">Entity mapeada da base de dados</param>
        private void Atribuir(FuncionarioModel funcionarioModel, tb_funcionario funcionarioE)
        {            
            funcionarioE.idFuncionario = funcionarioModel.IdPessoa;
            funcionarioE.tipoConta = funcionarioModel.TipoConta;
            funcionarioE.banco = funcionarioModel.Banco;
            funcionarioE.agencia = funcionarioModel.Agencia;
            funcionarioE.numeroConta = funcionarioModel.NumeroConta;
            funcionarioE.idPessoa = funcionarioModel.IdPessoa;
            
        }
    }
}
