using Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Data;
using Model.Models;
using Model;
using System.Linq;
using System.Collections.Generic;

namespace ServiceTests
{
    
    
    /// <summary>
    ///This is a test class for GerenciadorPedidoTest and is intended
    ///to contain all GerenciadorPedidoTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GerenciadorPedidoTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for GerenciadorPedido Constructor
        ///</summary>
        [TestMethod()]
        public void GerenciadorPedidoConstructorTest()
        {
            IUnitOfWork unitOfWork = null; // TODO: Initialize to an appropriate value
            GerenciadorPedido target = new GerenciadorPedido(unitOfWork);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GerenciadorPedido Constructor
        ///</summary>
        [TestMethod()]
        public void GerenciadorPedidoConstructorTest1()
        {
            GerenciadorPedido target = new GerenciadorPedido();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Atribuir
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Service.dll")]
        public void AtribuirTest()
        {
            GerenciadorPedido_Accessor target = new GerenciadorPedido_Accessor(); // TODO: Initialize to an appropriate value
            PedidoModel pedidoModel = null; // TODO: Initialize to an appropriate value
            tb_pedido pedidoE = null; // TODO: Initialize to an appropriate value
            target.Atribuir(pedidoModel, pedidoE);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetQuery
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Service.dll")]
        public void GetQueryTest()
        {
            GerenciadorPedido_Accessor target = new GerenciadorPedido_Accessor(); // TODO: Initialize to an appropriate value
            IQueryable<PedidoModel> expected = null; // TODO: Initialize to an appropriate value
            IQueryable<PedidoModel> actual;
            actual = target.GetQuery();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }


        /// <summary>
        ///A test for Inserir
        ///</summary>
        [TestMethod()]
        public void InserirValidoTest()
        {
            GerenciadorPedido target = new GerenciadorPedido(); // TODO: Initialize to an appropriate value
            PedidoModel pedidoModel = new PedidoModel(); // TODO: Initialize to an appropriate value
            pedidoModel.IdPedido = 1;
            pedidoModel.IdPessoa = 1;
            pedidoModel.DataCriacao = DateTime.Now;
            pedidoModel.DataEmissao = DateTime.Now;
            pedidoModel.NomePedido = "Orçamento do Casamento de Pedro";
            pedidoModel.NomePessoa = "Pedro";
            pedidoModel.StatusContrato = "Em Debito";
            pedidoModel.StatusPedido = "Orcamento";
            pedidoModel.Valor = 3456;

            int actual;
            actual = target.Inserir(pedidoModel);
            Assert.IsTrue(actual > 0);

            PedidoModel novoPedidoModel = new PedidoModel();
            Assert.IsNotNull(novoPedidoModel);
            Assert.Equals(pedidoModel.IdPedido, novoPedidoModel.IdPedido);
            Assert.Equals(pedidoModel.IdPessoa, novoPedidoModel.IdPessoa);
            Assert.Equals(pedidoModel.DataCriacao, novoPedidoModel.DataCriacao);
            Assert.Equals(pedidoModel.DataEmissao, novoPedidoModel.DataEmissao);
            Assert.Equals(pedidoModel.NomePedido, novoPedidoModel.NomePedido);
            Assert.Equals(pedidoModel.NomePessoa, novoPedidoModel.NomePessoa);
            Assert.Equals(pedidoModel.StatusContrato, novoPedidoModel.StatusContrato);
            Assert.Equals(pedidoModel.StatusPedido, novoPedidoModel.StatusPedido);
            Assert.Equals(pedidoModel.Valor, novoPedidoModel.Valor);
        }

        /// <summary>
        ///A test for Inserir
        ///</summary>
        [TestMethod()]
        public void InserirInvalidoTest()
        {
            GerenciadorPedido target = new GerenciadorPedido(); // TODO: Initialize to an appropriate value
            PedidoModel pedidoModel = new PedidoModel(); // TODO: Initialize to an appropriate value
            pedidoModel.IdPedido = 1;
            pedidoModel.IdPessoa = 1;
            pedidoModel.DataCriacao = DateTime.Now;
            pedidoModel.DataEmissao = DateTime.Now;
            pedidoModel.NomePedido = null;
            pedidoModel.NomePessoa = "Pedro";
            pedidoModel.StatusContrato = null;

            int actual;
            actual = target.Inserir(pedidoModel);

            PedidoModel novoPedido = target.Obter(actual);
            Assert.IsNull(novoPedido);
        }

        /// <summary>
        ///A test for Editar
        ///</summary>
        [TestMethod()]
        public void EditarValidoTest()
        {
            GerenciadorPedido target = new GerenciadorPedido(); // TODO: Initialize to an appropriate value
            PedidoModel pedidoModel = target.Obter(1);
            pedidoModel.IdPedido = 1;
            pedidoModel.IdPessoa = 1;
            pedidoModel.DataCriacao = DateTime.Now;
            pedidoModel.DataEmissao = DateTime.Now;
            pedidoModel.NomePedido = "Orçamento do Casamento de Pedro";
            pedidoModel.NomePessoa = "Pedro";
            pedidoModel.StatusContrato = "Em Debito";
            pedidoModel.StatusPedido = "Orcamento";
            pedidoModel.Valor = 1000;

            target.Editar(pedidoModel);

            PedidoModel novoPedido = target.Obter(1);
            Assert.IsNotNull(novoPedido);
            Assert.AreNotEqual(pedidoModel.Valor, novoPedido.Valor);
        }

        /// <summary>
        ///A test for Editar
        ///</summary>
        [TestMethod()]
        public void EditarInvalidoTest()
        {
            GerenciadorPedido target = new GerenciadorPedido(); // TODO: Initialize to an appropriate value
            PedidoModel pedidoModel = target.Obter(1);
            pedidoModel.IdPedido = 1;
            pedidoModel.IdPessoa = 1;
            pedidoModel.DataCriacao = DateTime.Now;
            pedidoModel.DataEmissao = DateTime.Now;
            pedidoModel.NomePedido = null;

            target.Editar(pedidoModel);

            PedidoModel novoPedido = target.Obter(1);
            Assert.IsNotNull(novoPedido);
            Assert.AreEqual(pedidoModel.NomePedido, novoPedido.NomePedido);
        }

        /// <summary>
        ///A test for Remover
        ///</summary>
        [TestMethod()]
        public void RemoverTest()
        {
            GerenciadorPedido target = new GerenciadorPedido(); // TODO: Initialize to an appropriate value
            int idPedido = 1; // TODO: Initialize to an appropriate value
            target.Remover(idPedido);
            PedidoModel pedidoModel = target.Obter(idPedido);
            Assert.IsNull(pedidoModel);
        }

        /// <summary>
        ///A test for Obter
        ///</summary>
        [TestMethod()]
        public void ObterTest()
        {
            GerenciadorPedido target = new GerenciadorPedido(); // TODO: Initialize to an appropriate value
            PedidoModel actual = target.Obter(1);
            Assert.IsNotNull(actual);
            Assert.AreEqual(actual.IdPedido, 1);
            Assert.AreEqual(actual.IdPessoa, 1);
            Assert.AreEqual(actual.NomePedido, "Orçamento do Casamento de Pedro");
            Assert.AreEqual(actual.NomePessoa, "Pedro");
            Assert.AreEqual(actual.StatusContrato, "Em Debito");
            Assert.AreEqual(actual.StatusPedido, "Orcamento");
            Assert.AreEqual(actual.Valor, 1000);
        }

        /// <summary>
        ///A test for ObterPorCliente
        ///</summary>
        [TestMethod()]
        public void ObterPorClienteTest()
        {
            GerenciadorPedido target = new GerenciadorPedido(); // TODO: Initialize to an appropriate value
            int idCliente = 1; // TODO: Initialize to an appropriate value
            IEnumerable<PedidoModel> actual = target.ObterPorCliente(idCliente);
            Assert.Equals(actual.Count(), 1);
            foreach (var pedido in actual)
            {
                Assert.Equals(idCliente, pedido.IdPessoa);
            }
        }

        /// <summary>
        ///A test for ObterPorNome
        ///</summary>
        [TestMethod()]
        public void ObterPorNomeTest()
        {
            GerenciadorPedido target = new GerenciadorPedido(); // TODO: Initialize to an appropriate value
            string nome = "Orçamento do Casamento de Pedro";
            IEnumerable<PedidoModel> actual = target.ObterPorNome(nome);
            Assert.Equals(actual.Count(), 1);
            foreach (var pedido in actual)
            {
                Assert.Equals(nome, pedido.NomePedido);
            }
        }

        /// <summary>
        ///A test for ObterTodos
        ///</summary>
        [TestMethod()]
        public void ObterTodosTest()
        {
            GerenciadorPedido target = new GerenciadorPedido(); // TODO: Initialize to an appropriate value
            IEnumerable<PedidoModel> actual = target.ObterTodos();
            Assert.IsInstanceOfType(actual, typeof(IEnumerable<PedidoModel>));
            Assert.Equals(actual.Count(), 1);
        }

    }
}
