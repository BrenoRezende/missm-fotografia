using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Models;
using Model;
using Service;
using Microsoft.Reporting.WebForms;

namespace ViewController.Controllers
{
    public class OrcamentoController : Controller
    {
        private GerenciadorOrcamento gOrcamento;
        private GerenciadorProduto gProduto;
        private GerenciadorServico gServico;
        private GerenciadorTipoEvento gTipoDeEvento;


        private decimal valorProduto = 0;

        public OrcamentoController()
        {
            this.gOrcamento = new GerenciadorOrcamento();
            this.gProduto = new GerenciadorProduto();
            this.gServico = new GerenciadorServico();
            this.gTipoDeEvento = new GerenciadorTipoEvento();
        }

        public ActionResult Index()
        {

            var produtos = ObterTodosProdutosParaExibicao(this.gProduto);
            ViewBag.listaProdutos = new SelectList(produtos, "Id", "NomeExibido");
            ViewBag.valorPro = valorProduto;

            var servicos = ObterTodosServicosParaExibicao(this.gServico);
            ViewBag.listaServicos = new SelectList(servicos, "Id", "NomeExibido");

            var tiposDeEvento = ObterTodosTiposDeEventoParaExibicao(this.gTipoDeEvento);
            ViewBag.listaTipoDeEventos = new SelectList(tiposDeEvento, "Id", "NomeExibido");


            return View();
        }

        [HttpPost]
        public ActionResult Index(ProdutoModel produtoModel)
        {
            if (ModelState.IsValid)
            {
                ViewBag.recebeProduto = produtoModel;
                return RedirectToAction("Index");
            }
            return View(produtoModel);
        }



        /// <summary>
        /// Obter todos os tipos de evento cadastrados, personalizados para exibicao
        /// </summary>
        /// <param name="gProduto"></param>
        /// <returns>Lista com dados personalizados para exibicao</returns>
        public List<object> ObterTodosProdutosParaExibicao(GerenciadorProduto gProduto)
        {
            var produtos = gProduto.ObterTodos();
            List<object> produtosLista = new List<object>();

            foreach (var tp in produtos)
                produtosLista.Add(new
                {
                    Id = tp.IdProduto,
                    NomeExibido = "Nome: " + tp.Nome + "...................| Formato: " + tp.Formato + "...................| Número de Páginas: " + tp.NumeroDePaginas
                    + "...................| Número de Imágens: " + tp.NumeroDeImagens

                });

            return produtosLista;
        }


        /// <summary>
        /// Obter todos os tipos de evento cadastrados, personalizados para exibicao
        /// </summary>
        /// <param name="gServico"></param>
        /// <returns>Lista com dados personalizados para exibicao</returns>
        public List<object> ObterTodosServicosParaExibicao(GerenciadorServico gServico)
        {
            var servicos = gServico.ObterTodos();
            List<object> servicosLista = new List<object>();

            foreach (var ts in servicos)
                servicosLista.Add(new
                {
                    Id = ts.IdServico,
                    NomeExibido = "Tipo de Serviço: " + ts.NomeServico + "...................| Nome do Parceiro: " + ts.NomeParceiro + "...................| Tel. Parceiro: " + ts.TelefoneParceiro
                    + "...................| Valor: " + ts.ValorCobradoAoCliente

                });

            return servicosLista;
        }

        /// <summary>
        /// Obter todos os tipos de evento cadastrados, personalizados para exibicao
        /// </summary>
        /// <param name="gTipoDeEvento"></param>
        /// <returns>Lista com dados personalizados para exibicao</returns>
        public List<object> ObterTodosTiposDeEventoParaExibicao(GerenciadorTipoEvento gTipoDeEvento)
        {
            var tipoDeEventos = gTipoDeEvento.ObterTodos();
            List<object> tiposDeEventoLista = new List<object>();

            foreach (var tte in tipoDeEventos)
                tiposDeEventoLista.Add(new
                {
                    Id = tte.IdTipoEvento,
                    NomeExibido = "Nome: " + tte.Nome + "...................| Total de Convidados: " + tte.TotalConvidados + "...................| Valor: " + tte.Valor

                });

            return tiposDeEventoLista;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

    }
}
