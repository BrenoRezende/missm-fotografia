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
    ///This is a test class for GerenciadorEventoTest and is intended
    ///to contain all GerenciadorEventoTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GerenciadorEventoTest
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
        ///A test for GerenciadorEvento Constructor
        ///</summary>
        [TestMethod()]
        public void GerenciadorEventoConstructorTest()
        {
            IUnitOfWork unitOfWork = null; // TODO: Initialize to an appropriate value
            GerenciadorEvento target = new GerenciadorEvento(unitOfWork);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GerenciadorEvento Constructor
        ///</summary>
        [TestMethod()]
        public void GerenciadorEventoConstructorTest1()
        {
            GerenciadorEvento target = new GerenciadorEvento();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Atribuir
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Service.dll")]
        public void AtribuirTest()
        {
            GerenciadorEvento_Accessor target = new GerenciadorEvento_Accessor(); // TODO: Initialize to an appropriate value
            EventoModel eventoModel = null; // TODO: Initialize to an appropriate value
            tb_evento eventoE = null; // TODO: Initialize to an appropriate value
            target.Atribuir(eventoModel, eventoE);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetQuery
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Service.dll")]
        public void GetQueryTest()
        {
            GerenciadorEvento_Accessor target = new GerenciadorEvento_Accessor(); // TODO: Initialize to an appropriate value
            IQueryable<EventoModel> expected = null; // TODO: Initialize to an appropriate value
            IQueryable<EventoModel> actual;
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
            GerenciadorEvento target = new GerenciadorEvento(); // TODO: Initialize to an appropriate value
            EventoModel eventoModel = new EventoModel();
            eventoModel.IdEvento = 1;
            eventoModel.IdTipoEvento = 1;
            eventoModel.Nome = "Casamento de Pedro e Maria";
            eventoModel.Data = DateTime.Now;
            eventoModel.NomeTipoEvento = "Casamento";

            int actual;
            actual = target.Inserir(eventoModel);
            Assert.IsTrue(actual > 0);

            EventoModel novoEvento = target.Obter(actual);
            Assert.IsNotNull(novoEvento);
            Assert.Equals(eventoModel.IdEvento, novoEvento.IdEvento);
            Assert.Equals(eventoModel.IdTipoEvento, novoEvento.IdTipoEvento);
            Assert.Equals(eventoModel.Nome, novoEvento.Nome);
            Assert.Equals(eventoModel.Data, novoEvento.Data);
            Assert.Equals(eventoModel.NomeTipoEvento, novoEvento.NomeTipoEvento);
        }

        /// <summary>
        ///A test for Inserir
        ///</summary>
        [TestMethod()]
        public void InserirInvalidoTest()
        {
            GerenciadorEvento target = new GerenciadorEvento(); // TODO: Initialize to an appropriate value
            EventoModel eventoModel = new EventoModel();
            eventoModel.IdEvento = 1;
            eventoModel.IdTipoEvento = 1;
            eventoModel.Nome = null;
            eventoModel.Data = DateTime.Now;
            eventoModel.NomeTipoEvento = "Casamento";

            int actual;
            actual = target.Inserir(eventoModel);

            EventoModel novoEvento = target.Obter(actual);
            Assert.IsNull(novoEvento);
        }


        /// <summary>
        ///A test for Editar
        ///</summary>
        [TestMethod()]
        public void EditarValidoTest()
        {
            GerenciadorEvento target = new GerenciadorEvento(); // TODO: Initialize to an appropriate value
            EventoModel eventoModel = target.Obter(1);
            eventoModel.IdEvento = 1;
            eventoModel.IdTipoEvento = 1;
            eventoModel.Nome = "Casamento de Maria e Pedro";
            eventoModel.Data = DateTime.Now;
            eventoModel.NomeTipoEvento = "Casamento";
            
            target.Editar(eventoModel);

            EventoModel novoEvento = target.Obter(1);
            Assert.IsNotNull(novoEvento);
            Assert.AreNotEqual(eventoModel.Nome, novoEvento.Nome); 
        }

        /// <summary>
        ///A test for Editar
        ///</summary>
        [TestMethod()]
        public void EditarInvalidoTest()
        {
            GerenciadorEvento target = new GerenciadorEvento(); // TODO: Initialize to an appropriate value
            EventoModel eventoModel = target.Obter(1);
            eventoModel.IdEvento = 1;
            eventoModel.IdTipoEvento = 1;
            eventoModel.Nome = null;
           
            target.Editar(eventoModel);

            EventoModel novoEvento = target.Obter(1);
            Assert.IsNotNull(novoEvento);
            Assert.AreEqual(eventoModel.Nome, novoEvento.Nome);
        }


        /// <summary>
        ///A test for Remover
        ///</summary>
        [TestMethod()]
        public void RemoverTest()
        {
            GerenciadorEvento target = new GerenciadorEvento(); // TODO: Initialize to an appropriate value
            int idEvento = 1; // TODO: Initialize to an appropriate value
            target.Remover(idEvento);
            EventoModel eventoModel = target.Obter(idEvento);
            Assert.IsNull(eventoModel);
        }

        
        /// <summary>
        ///A test for Obter
        ///</summary>
        [TestMethod()]
        public void ObterTest()
        {
            GerenciadorEvento target = new GerenciadorEvento(); // TODO: Initialize to an appropriate value
            EventoModel actual = target.Obter(1);
            Assert.IsNotNull(actual);
            Assert.AreEqual(actual.IdEvento, 1);
            Assert.AreEqual(actual.IdTipoEvento, 1);
            Assert.AreEqual(actual.Nome, "Casamento de Maria e Pedro");
            Assert.AreEqual(actual.NomeTipoEvento, "Casamento");
        }

        /// <summary>
        ///A test for ObterPorNome
        ///</summary>
        [TestMethod()]
        public void ObterPorNomeTest()
        {
            GerenciadorEvento target = new GerenciadorEvento(); // TODO: Initialize to an appropriate value
            string nome = "Casamento de Maria e Pedro"; // TODO: Initialize to an appropriate value
            IEnumerable<EventoModel> actual = target.ObterPorNome(nome);
            Assert.Equals(actual.Count(), 1);
            foreach (var evento in actual)
            {
                Assert.Equals(nome, evento.Nome);
            }
        }
        /// <summary>
        ///A test for ObterTodos
        ///</summary>
        [TestMethod()]
        public void ObterTodosTest()
        {
            GerenciadorEvento target = new GerenciadorEvento(); // TODO: Initialize to an appropriate value
            IEnumerable<EventoModel> actual = target.ObterTodos();
            Assert.IsInstanceOfType(actual, typeof(IEnumerable<EventoModel>));
            Assert.Equals(actual.Count(), 1);
        }

    }
}
