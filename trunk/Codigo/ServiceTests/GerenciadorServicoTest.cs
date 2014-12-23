using Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Data;
using Model.Models;
using Model;
using System.Linq;
using System.Collections.Generic;

namespace Service.Tests
{


    /// <summary>
    ///This is a test class for GerenciadorServicoTest and is intended
    ///to contain all GerenciadorServicoTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GerenciadorServicoTest
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
        ///A test for GerenciadorServico Constructor
        ///</summary>
        [TestMethod()]
        public void GerenciadorServicoConstructorTest()
        {
            GerenciadorServico target = new GerenciadorServico();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GerenciadorServico Constructor
        ///</summary>
        [TestMethod()]
        public void GerenciadorServicoConstructorTest1()
        {
            IUnitOfWork unitOfWork = null; // TODO: Initialize to an appropriate value
            GerenciadorServico target = new GerenciadorServico(unitOfWork);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Atribuir
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Service.dll")]
        public void AtribuirTest()
        {
            GerenciadorServico_Accessor target = new GerenciadorServico_Accessor(); // TODO: Initialize to an appropriate value
            ServicoModel servicoModel = null; // TODO: Initialize to an appropriate value
            tb_servico servicoE = null; // TODO: Initialize to an appropriate value
            target.Atribuir(servicoModel, servicoE);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Editar
        ///</summary>
        [TestMethod()]
        public void EditarValidoTest()
        {
            GerenciadorServico target = new GerenciadorServico(); // TODO: Initialize to an appropriate value
            ServicoModel servico = target.Obter(4);
            ServicoModel servicoEsperado = servico;
            servicoEsperado.NomeServico = "Maquiágem";
            target.Editar(servicoEsperado);
            ServicoModel atual = target.Obter(4);
            Assert.IsNotNull(atual);
            Assert.AreEqual(atual, servicoEsperado);
            Assert.AreSame(atual, servicoEsperado);
            Assert.AreNotEqual(servicoEsperado.NomeServico, servico.NomeServico);
        }

        /// <summary>
        ///A test for Editar
        ///</summary>
        [TestMethod()]
        public void EditarInvalidoTest()
        {
            GerenciadorServico target = new GerenciadorServico(); // TODO: Initialize to an appropriate value
            ServicoModel servico = target.Obter(4);
            ServicoModel servicoEsperado = servico;
            servicoEsperado.NomeServico = null;
            try
            {
                target.Editar(servicoEsperado);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(Exception));
            }
            ServicoModel actual = target.Obter(4);
            Assert.Equals(actual.NomeServico, servico.NomeServico);
            Assert.AreNotEqual(servicoEsperado, actual);
        }

        /// <summary>
        ///A test for GetQuery
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Service.dll")]
        public void GetQueryTest()
        {
            GerenciadorServico_Accessor target = new GerenciadorServico_Accessor(); // TODO: Initialize to an appropriate value
            IQueryable<ServicoModel> expected = null; // TODO: Initialize to an appropriate value
            IQueryable<ServicoModel> actual;
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
            GerenciadorServico target = new GerenciadorServico(); // TODO: Initialize to an appropriate value
            ServicoModel servicoModel = new ServicoModel();
            servicoModel.NomeServico = "Penteado";
            servicoModel.NomeParceiro = "Adriana de Melo";
            servicoModel.TelefoneParceiro = "9889-0990";
            servicoModel.ValorServico = 60;
            servicoModel.ValorCobradoAoCliente = 90;
            int idServico = target.Inserir(servicoModel);

            Assert.IsTrue(idServico > 0);
            ServicoModel servicoInserido = target.Obter(idServico);
            Assert.IsNotNull(servicoInserido);
            Assert.AreSame(servicoModel, servicoInserido);
        }


        /// <summary>
        ///A test for Inserir
        ///</summary>
        [TestMethod()]
        public void InserirInvalidoTest()
        {
            GerenciadorServico target = new GerenciadorServico(); // TODO: Initialize to an appropriate value
            ServicoModel servicoModel = new ServicoModel();
            servicoModel.NomeServico = "Penteado";
            servicoModel.NomeParceiro = "Adriana de Melo";
            servicoModel.TelefoneParceiro = "9889-0990";
            servicoModel.ValorServico = 60;
            servicoModel.ValorCobradoAoCliente = 90;
            int actual = 0;
            try
            {
                actual = target.Inserir(servicoModel);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(Exception));
            }
            ServicoModel servicoInserido = target.Obter(actual);
            Assert.IsNull(servicoInserido);
        }

        /// <summary>
        ///A test for Obter
        ///</summary>
        [TestMethod()]
        public void ObterValidoTest()
        {
            GerenciadorServico target = new GerenciadorServico(); // TODO: Initialize to an appropriate value
            ServicoModel expected = target.Obter(4);
            ServicoModel actual = target.Obter(4);
            Assert.AreEqual(expected, actual);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///A test for Obter
        ///</summary>
        [TestMethod()]
        public void ObterInvalidoTest()
        {
            GerenciadorServico target = new GerenciadorServico(); // TODO: Initialize to an appropriate value
            ServicoModel expected = null;
            ServicoModel actual = target.Obter(-1);
            Assert.AreEqual(expected, actual);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///A test for ObterPorNome
        ///</summary>
        [TestMethod()]
        public void ObterPorNomeTest()
        {
            GerenciadorServico target = new GerenciadorServico(); // TODO: Initialize to an appropriate value
            string nomeServico = "Maquiágem";
            IEnumerable<ServicoModel> expected = target.ObterPorNome(nomeServico);
            IEnumerable<ServicoModel> actual = target.ObterPorNome(nomeServico);
            Assert.AreEqual(expected, actual);
            foreach (var servico in actual)
            {
                Assert.Equals(nomeServico, servico.NomeServico);
            }
        }

        /// <summary>
        ///A test for ObterTodos
        ///</summary>
        [TestMethod()]
        public void ObterTodosTest()
        {
            GerenciadorServico target = new GerenciadorServico(); // TODO: Initialize to an appropriate value
            IEnumerable<ServicoModel> expected = target.ObterTodos();
            IEnumerable<ServicoModel> actual = target.ObterTodos();
            Assert.AreEqual(expected, actual);
            Assert.IsInstanceOfType(actual, typeof(IEnumerable<ProdutoModel>));
        }

        /// <summary>
        ///A test for Remover
        ///</summary>
        [TestMethod()]
        public void RemoverTest()
        {
            GerenciadorServico target = new GerenciadorServico(); // TODO: Initialize to an appropriate value
            int idServico = 3; // TODO: Initialize to an appropriate value
            target.Remover(idServico);
            ServicoModel servico = target.Obter(idServico);
            Assert.IsNull(servico);
        }
    }
}
