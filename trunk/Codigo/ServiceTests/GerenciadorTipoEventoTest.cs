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
    ///This is a test class for GerenciadorTipoEventoTest and is intended
    ///to contain all GerenciadorTipoEventoTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GerenciadorTipoEventoTest
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
        ///A test for GerenciadorTipoEvento Constructor
        ///</summary>
        [TestMethod()]
        public void GerenciadorTipoEventoConstructorTest()
        {
            IUnitOfWork unitOfWork = null; // TODO: Initialize to an appropriate value
            GerenciadorTipoEvento target = new GerenciadorTipoEvento(unitOfWork);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GerenciadorTipoEvento Constructor
        ///</summary>
        [TestMethod()]
        public void GerenciadorTipoEventoConstructorTest1()
        {
            GerenciadorTipoEvento target = new GerenciadorTipoEvento();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Atribuir
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Service.dll")]
        public void AtribuirTest()
        {
            GerenciadorTipoEvento_Accessor target = new GerenciadorTipoEvento_Accessor(); // TODO: Initialize to an appropriate value
            TipoEventoModel tipoEventoModel = null; // TODO: Initialize to an appropriate value
            tb_tipo_evento tipoEventoE = null; // TODO: Initialize to an appropriate value
            target.Atribuir(tipoEventoModel, tipoEventoE);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetQuery
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Service.dll")]
        public void GetQueryTest()
        {
            GerenciadorTipoEvento_Accessor target = new GerenciadorTipoEvento_Accessor(); // TODO: Initialize to an appropriate value
            IQueryable<TipoEventoModel> expected = null; // TODO: Initialize to an appropriate value
            IQueryable<TipoEventoModel> actual;
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
            GerenciadorTipoEvento target = new GerenciadorTipoEvento(); // TODO: Initialize to an appropriate value
            TipoEventoModel tipoEventoModel = new TipoEventoModel(); // TODO: Initialize to an appropriate value
            tipoEventoModel.IdTipoEvento = 1;
            tipoEventoModel.Nome = "Casamento";
            tipoEventoModel.TotalConvidados = 1000;
            tipoEventoModel.Valor = 2000;

            int actual;
            actual = target.Inserir(tipoEventoModel);
            Assert.IsTrue(actual > 0);
        }

        /// <summary>
        ///A test for Inserir
        ///</summary>
        [TestMethod()]
        public void InserirInvalidoTest()
        {
            GerenciadorTipoEvento target = new GerenciadorTipoEvento(); // TODO: Initialize to an appropriate value
            TipoEventoModel tipoEventoModel = new TipoEventoModel(); // TODO: Initialize to an appropriate value
            tipoEventoModel.IdTipoEvento = 1;
            tipoEventoModel.Nome = null;
            tipoEventoModel.TotalConvidados = 1000;
            tipoEventoModel.Valor = 2000;

            int actual;
            actual = target.Inserir(tipoEventoModel);
  

            TipoEventoModel tipoEventoInserido = target.Obter(actual);
            Assert.IsNull(tipoEventoInserido);

        }

        /// <summary>
        ///A test for Editar
        ///</summary>
        [TestMethod()]
        public void EditarValidoTest()
        {
            GerenciadorTipoEvento target = new GerenciadorTipoEvento(); // TODO: Initialize to an appropriate value
            TipoEventoModel tipoEventoModel = target.Obter(1); // TODO: Initialize to an appropriate value
            tipoEventoModel.IdTipoEvento = 1;
            tipoEventoModel.Nome = "Casamento";
            tipoEventoModel.TotalConvidados = 2000;
            tipoEventoModel.Valor = 2000;

            try
            {
                target.Editar(tipoEventoModel);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(Exception));
            }

            TipoEventoModel novoTipoEvento = target.Obter(1);
            Assert.IsNotNull(novoTipoEvento);
            Assert.IsInstanceOfType(novoTipoEvento, typeof(TipoEventoModel));
            Assert.AreNotEqual(tipoEventoModel.TotalConvidados, novoTipoEvento.TotalConvidados);   
        }

        /// <summary>
        ///A test for Editar
        ///</summary>
        [TestMethod()]
        public void EditarInvalidoTest()
        {
            GerenciadorTipoEvento target = new GerenciadorTipoEvento(); // TODO: Initialize to an appropriate value
            TipoEventoModel tipoEventoModel = target.Obter(1); // TODO: Initialize to an appropriate value
            tipoEventoModel.IdTipoEvento = 1;
            tipoEventoModel.Nome = null;

            try
            {
                target.Editar(tipoEventoModel);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(Exception));
            }

            TipoEventoModel novoTipoEvento = target.Obter(1);
            Assert.IsNotNull(novoTipoEvento);
            Assert.IsInstanceOfType(novoTipoEvento, typeof(TipoEventoModel));
            Assert.AreEqual(tipoEventoModel.Nome, novoTipoEvento.Nome);
        }

        
        /// <summary>
        ///A test for Remover
        ///</summary>
        [TestMethod()]
        public void RemoverTest()
        {
            GerenciadorTipoEvento target = new GerenciadorTipoEvento(); // TODO: Initialize to an appropriate value
            int idTipoEvento = 1; // TODO: Initialize to an appropriate value
            target.Remover(idTipoEvento);
            TipoEventoModel tipoEvento = target.Obter(idTipoEvento);
            Assert.IsNull(tipoEvento);
        }

        /// <summary>
        ///A test for Obter
        ///</summary>
        [TestMethod()]
        public void ObterTest()
        {
            GerenciadorTipoEvento target = new GerenciadorTipoEvento(); // TODO: Initialize to an appropriate value
            int idTipoEvento = 0; // TODO: Initialize to an appropriate value
            TipoEventoModel expected = null; // TODO: Initialize to an appropriate value
            TipoEventoModel actual;
            actual = target.Obter(idTipoEvento);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ObterPorNome
        ///</summary>
        [TestMethod()]
        public void ObterPorNomeTest()
        {
            GerenciadorTipoEvento target = new GerenciadorTipoEvento(); // TODO: Initialize to an appropriate value
            string nome = string.Empty; // TODO: Initialize to an appropriate value
            IEnumerable<TipoEventoModel> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<TipoEventoModel> actual;
            actual = target.ObterPorNome(nome);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ObterTodos
        ///</summary>
        [TestMethod()]
        public void ObterTodosTest()
        {
            GerenciadorTipoEvento target = new GerenciadorTipoEvento(); // TODO: Initialize to an appropriate value
            IEnumerable<TipoEventoModel> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<TipoEventoModel> actual;
            actual = target.ObterTodos();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

    }
}
