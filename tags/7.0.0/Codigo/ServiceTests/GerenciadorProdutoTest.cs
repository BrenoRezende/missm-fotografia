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
    ///This is a test class for GerenciadorProdutoTest and is intended
    ///to contain all GerenciadorProdutoTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GerenciadorProdutoTest
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
        ///A test for GerenciadorProduto Constructor
        ///</summary>
        [TestMethod()]
        public void GerenciadorProdutoConstructorTest()
        {
            GerenciadorProduto target = new GerenciadorProduto();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GerenciadorProduto Constructor
        ///</summary>
        [TestMethod()]
        public void GerenciadorProdutoConstructorTest1()
        {
            IUnitOfWork unitOfWork = null; // TODO: Initialize to an appropriate value
            GerenciadorProduto target = new GerenciadorProduto(unitOfWork);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Atribuir
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Service.dll")]
        public void AtribuirTest()
        {
            GerenciadorProduto_Accessor target = new GerenciadorProduto_Accessor(); // TODO: Initialize to an appropriate value
            ProdutoModel produtoModel = null; // TODO: Initialize to an appropriate value
            tb_produto produtoE = null; // TODO: Initialize to an appropriate value
            target.Atribuir(produtoModel, produtoE);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Editar
        ///</summary>
        [TestMethod()]
        public void EditarValidoTest()
        {
            GerenciadorProduto target = new GerenciadorProduto(); // TODO: Initialize to an appropriate value
            ProdutoModel produto = target.Obter(4);
            ProdutoModel produtoEsperado = produto;
            produtoEsperado.Nome = "Foto Livro";
            target.Editar(produtoEsperado);
            ProdutoModel atual = target.Obter(4);
            Assert.IsNotNull(atual);
            Assert.AreEqual(atual, produtoEsperado);
            Assert.AreSame(atual, produtoEsperado);
            Assert.AreNotEqual(produtoEsperado.Nome, produto.Nome);
        }

        /// <summary>
        ///A test for Editar
        ///</summary>
        [TestMethod()]
        public void EditarInvalidoTest()
        {
            GerenciadorProduto target = new GerenciadorProduto(); // TODO: Initialize to an appropriate value
            ProdutoModel produto = target.Obter(4);
            ProdutoModel produtoEsperado = produto;
            produtoEsperado.Nome = null;
            try
            {
                target.Editar(produtoEsperado);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(Exception));
            }
            ProdutoModel actual = target.Obter(4);
            Assert.Equals(actual.Nome, produto.Nome);
            Assert.AreNotEqual(produtoEsperado, actual);
        }

        /// <summary>
        ///A test for GetQuery
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Service.dll")]
        public void GetQueryTest()
        {
            GerenciadorProduto_Accessor target = new GerenciadorProduto_Accessor(); // TODO: Initialize to an appropriate value
            IQueryable<ProdutoModel> expected = null; // TODO: Initialize to an appropriate value
            IQueryable<ProdutoModel> actual;
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
            GerenciadorProduto target = new GerenciadorProduto(); // TODO: Initialize to an appropriate value
            ProdutoModel produtoModel = new ProdutoModel();
            produtoModel.Nome = "Foto Livro";
            produtoModel.NumeroDePaginas = 30;
            produtoModel.Formato = "15X21";
            produtoModel.NumeroDeImagens = 40;
            produtoModel.ValorDoProduto = 2400;
            int idProduto = target.Inserir(produtoModel);

            Assert.IsTrue(idProduto > 0);
            ProdutoModel produtoInserido = target.Obter(idProduto);
            Assert.IsNotNull(produtoInserido);
            Assert.AreSame(produtoModel, produtoInserido);

        }

        /// <summary>
        ///A test for Inserir
        ///</summary>
        [TestMethod()]
        public void InserirInvalidoTest()
        {
            GerenciadorProduto target = new GerenciadorProduto();
            ProdutoModel produtoModel = new ProdutoModel();
            produtoModel.Nome = "Foto Livro";
            produtoModel.NumeroDePaginas = 30;
            produtoModel.Formato = "15X21";
            produtoModel.NumeroDeImagens = 40;
            produtoModel.ValorDoProduto = 2400;
            int actual = 0;
            try
            {
                actual = target.Inserir(produtoModel);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(Exception));
            }
            ProdutoModel produtoInserido = target.Obter(actual);
            Assert.IsNull(produtoInserido);
        }

        /// <summary>
        ///A test for Obter
        ///</summary>
        [TestMethod()]
        public void ObterValidoTest()
        {
            GerenciadorProduto target = new GerenciadorProduto();
            ProdutoModel expected = target.Obter(4);
            ProdutoModel actual = target.Obter(4);
            Assert.AreEqual(expected, actual);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///A test for Obter
        ///</summary>
        [TestMethod()]
        public void ObterInvalidoTest()
        {
            GerenciadorProduto target = new GerenciadorProduto();
            ProdutoModel expected = null;
            ProdutoModel actual = target.Obter(-1);
            Assert.AreEqual(expected, actual);
            Assert.IsNull(actual);
        }

        /// <summary>
        ///A test for ObterPorNome
        ///</summary>
        [TestMethod()]
        public void ObterPorNomeTest()
        {
            GerenciadorProduto target = new GerenciadorProduto(); // TODO: Initialize to an appropriate value
            string nomeProduto = "Revista";
            IEnumerable<ProdutoModel> expected = target.ObterPorNome(nomeProduto);
            IEnumerable<ProdutoModel> actual = target.ObterPorNome(nomeProduto);
            Assert.AreEqual(expected, actual);
            foreach (var produto in actual)
            {
                Assert.Equals(nomeProduto, produto.Nome);
            }
        }

        /// <summary>
        ///A test for ObterTodos
        ///</summary>
        [TestMethod()]
        public void ObterTodosTest()
        {
            GerenciadorProduto target = new GerenciadorProduto(); // TODO: Initialize to an appropriate value
            IEnumerable<ProdutoModel> expected = target.ObterTodos();
            IEnumerable<ProdutoModel> actual = target.ObterTodos(); ;
            Assert.AreEqual(expected, actual);
            Assert.IsInstanceOfType(actual, typeof(IEnumerable<ProdutoModel>));
        }

        /// <summary>
        ///A test for Remover
        ///</summary>
        [TestMethod()]
        public void RemoverTest()
        {
            GerenciadorProduto target = new GerenciadorProduto(); // TODO: Initialize to an appropriate value
            int idProduto = 3; // TODO: Initialize to an appropriate value
            target.Remover(idProduto);
            ProdutoModel produto = target.Obter(idProduto);
            Assert.IsNull(produto);
        }
    }
}
