using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Model.Models;
using Data;


namespace Service
{
    public class GerenciadorCliente
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        /// <summary>
        /// Construtor pode ser acessado externamente e não compartilha contexto
        /// </summary>
         
        public GerenciadorCliente()
        {
            this.unitOfWork = new UnitOfWork();
            shared = false;
        }

        /// <summary>
        /// Construtor acessado apenas dentro do componentes service e permite compartilhar
        /// contexto com outras classes de negócio
        /// </summary>
        /// <param name="unitOfWork"></param>

        internal GerenciadorCliente(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            shared = true;
        }

        /// <summary>
        /// Insere um novo na base de dados
        /// </summary>
        /// <param name="clienteModel">Dados do modelo</param>
        /// <returns>Chave identificante na base</returns>

        public int Inserir(ClienteModel clienteModel)
        {
            tb_pessoa clienteE = new tb_pessoa();
            Atribuir(clienteModel, clienteE);
            unitOfWork.RepositorioCliente.Inserir(clienteE);
            unitOfWork.Commit(shared);
            return clienteE.idPessoa;
        }

        /// <summary>
        /// Altera dados na base de dados
        /// </summary>
        /// <param name="clienteModel"></param>
        public void Editar(ClienteModel clienteModel)
        {
            tb_pessoa clienteE = new tb_pessoa();
            Atribuir(clienteModel, clienteE);
            unitOfWork.RepositorioCliente.Editar(clienteE);
            unitOfWork.Commit(shared);
        }

        /// <summary>
        /// Remove da base de dados
        /// </summary>
        /// <param name="idCliente"></param>
        public void Remover(int idCliente)
        {
            unitOfWork.RepositorioCliente.Remover(cliente => cliente.idPessoa.Equals(idCliente));
            unitOfWork.Commit(shared);
        }


        /// <summary>
        /// Consulta padrão para retornar dados do cliente como model
        /// </summary>
        /// <returns></returns>
        private IQueryable<ClienteModel> GetQuery()
        {
            IQueryable<tb_pessoa> tb_cliente = unitOfWork.RepositorioCliente.GetQueryable();
            var query = from cliente in tb_cliente
                        select new ClienteModel
                        {
                            IdCliente = cliente.idPessoa,
                            Nome = cliente.nomePessoa,
                            Cpf = cliente.cpfPessoa,
                            Sexo = cliente.sexoPessoa,
                            DataNascimento = cliente.dataNascimentoPessoa,
                            Telefone = cliente.telefonePessoa,
                            Email = cliente.emailPessoa,
                            Senha = cliente.senhaPessoa,
                            Rua = cliente.rua,
                            Numero = cliente.numero,
                            Bairro = cliente.bairro,
                            Cidade = cliente.cidade,
                            Estado = cliente.estado,


                        };
            return query;
        }

        /// <summary>
        /// Obtém um Cliente
        /// </summary>
        /// <param name="idCliente">Identificador do cliente na base de dados</param>
        /// <returns>ClienteModel</returns>
        public ClienteModel Obter(int idCliente)
        {
            IEnumerable<ClienteModel> clientes = GetQuery().Where(clienteModel => clienteModel.IdCliente.Equals(idCliente));

            return clientes.ElementAtOrDefault(0);
        }

        /// <summary>
        /// Obtém um cliente pelo nome
        /// </summary>
        /// <param name="nome">Nome do cliente que será buscado base de dados</param>
        /// <returns>ClienteModel</returns>
        public IEnumerable<ClienteModel> ObterPorNome(string nome)
        {
            IEnumerable<ClienteModel> clientes = GetQuery().Where(clienteModel => clienteModel.Nome.StartsWith(nome));
            return clientes;
        }

        /// <summary>
        /// Obter todos as entidades cadastradas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ClienteModel> ObterTodos()
        {
            return GetQuery();
        }

        /// <summary>
        /// Atribui dados do ClienteModel para o Cliente Entity
        /// </summary>
        /// <param name="clienteModel">Objeto do modelo</param>
        /// <param name="clienteE">Entity mapeada da base de dados</param>
        private void Atribuir(ClienteModel clienteModel, tb_pessoa clienteE)
        {
            clienteE.idPessoa = clienteModel.IdCliente;
            clienteE.nomePessoa = clienteModel.Nome;
            clienteE.cpfPessoa = clienteModel.Cpf;
            clienteE.sexoPessoa = clienteModel.Sexo;
            clienteE.dataNascimentoPessoa = clienteModel.DataNascimento;
            clienteE.telefonePessoa = clienteModel.Telefone;
            clienteE.emailPessoa = clienteModel.Email;
            clienteE.senhaPessoa = clienteModel.Senha;
            clienteE.rua = clienteModel.Rua;
            clienteE.numero = clienteModel.Numero;
            clienteE.bairro = clienteModel.Bairro;
            clienteE.cidade = clienteModel.Cidade;
            clienteE.estado = clienteModel.Estado;

        }
    }
}
