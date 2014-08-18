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

        private GerenciadorProduto gProduto;
        private GerenciadorServico gServico;
        private GerenciadorTipoEvento gTipoDeEvento;
        private GerenciadorPedido gPedido;

        public OrcamentoController()
        {
            this.gProduto = new GerenciadorProduto();
            this.gServico = new GerenciadorServico();
            this.gTipoDeEvento = new GerenciadorTipoEvento();
            this.gPedido = new GerenciadorPedido();
        }

        public ActionResult Index()
        {
            OrcamentoModel orcamentoModel = new OrcamentoModel();

            orcamentoModel.Produto = new ProdutoModel();
            ViewBag.IdProduto = new SelectList(gProduto.ObterTodos(), "IdProduto", "Nome");
            orcamentoModel.ListaProdutos = SessionController.ListaProdutosEscolhidos;

            orcamentoModel.Servico = new ServicoModel();
            ViewBag.IdServico = new SelectList(gServico.ObterTodos(), "IdServico", "NomeServico");
            orcamentoModel.ListaServico = SessionController.ListaServicosEscolhidos;

            orcamentoModel.TipoEvento = new TipoEventoModel();
            ViewBag.IdTipoEvento = new SelectList(gTipoDeEvento.ObterTodos(), "IdTipoEvento", "Nome");
            orcamentoModel.ListaTipoEvento = SessionController.TipoEventoEscolhido;

            return View(orcamentoModel);
        }


        [HttpPost]
        public ActionResult NovoProduto(ProdutoModel produtoModel)
        {
            if (produtoModel.IdProduto > 0)
            {
                ProdutoModel pM = gProduto.Obter(produtoModel.IdProduto);
                List<ProdutoModel> ListaProdutos = (List<ProdutoModel>)SessionController.ListaProdutosEscolhidos;
                ListaProdutos.Add(pM);

                SessionController.ListaProdutosEscolhidos = ListaProdutos;
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult ListaProduto()
        {
            return View(SessionController.ListaProdutosEscolhidos);
        }

        public ActionResult RemoverProduto(int id)
        {

            List<ProdutoModel> listaProduto = SessionController.ListaProdutosEscolhidos;
            foreach (ProdutoModel pM in listaProduto)
            {
                if (id == pM.IdProduto)
                {
                    listaProduto.Remove(pM);
                    break;
                }
            }

            SessionController.ListaProdutosEscolhidos = listaProduto;
            return RedirectToAction("Index");
        }


        [HttpPost]
        public ActionResult NovoServico(ServicoModel servicoModel)
        {
            if (servicoModel.IdServico > 0)
            {
                ServicoModel sM = gServico.Obter(servicoModel.IdServico);
                List<ServicoModel> ListaServicos = (List<ServicoModel>)SessionController.ListaServicosEscolhidos;
                ListaServicos.Add(sM);

                SessionController.ListaServicosEscolhidos = ListaServicos;
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult ListaServico()
        {
            return View(SessionController.ListaServicosEscolhidos);
        }

        public ActionResult RemoverServico(int id)
        {

            List<ServicoModel> listaServico = SessionController.ListaServicosEscolhidos;
            foreach (ServicoModel sM in listaServico)
            {
                if (id == sM.IdServico)
                {
                    listaServico.Remove(sM);
                    break;
                }
            }

            SessionController.ListaServicosEscolhidos = listaServico;
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult NovoTipoEvento(TipoEventoModel tipoEventoModel)
        {
            if (tipoEventoModel.IdTipoEvento > 0)
            {
                TipoEventoModel sM = gTipoDeEvento.Obter(tipoEventoModel.IdTipoEvento);
                List<TipoEventoModel> ListaTipoEvento = (List<TipoEventoModel>)SessionController.TipoEventoEscolhido;
                ListaTipoEvento.Add(sM);

                SessionController.TipoEventoEscolhido = ListaTipoEvento;
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult ListaTipoEvento()
        {
            return View(SessionController.TipoEventoEscolhido);
        }

        public ActionResult RemoverTipoEvento(int id)
        {

            List<TipoEventoModel> listaTipoEvento = SessionController.TipoEventoEscolhido;
            foreach (TipoEventoModel tEM in listaTipoEvento)
            {
                if (id == tEM.IdTipoEvento)
                {
                    listaTipoEvento.Remove(tEM);
                    break;
                }
            }

            SessionController.TipoEventoEscolhido = listaTipoEvento;
            return RedirectToAction("Index");
        }

        public ActionResult Limpar()
        {
            SessionController.ListaProdutosEscolhidos = null;
            SessionController.ListaServicosEscolhidos = null;
            SessionController.TipoEventoEscolhido = null;

            return RedirectToAction("Index", "Orcamento");
        }

        public ActionResult VisualizarOrcamentos(int id)
        {
            IEnumerable<PedidoModel> orcamento = gPedido.ObterPorCliente(id);
            return View(orcamento);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

    }
}
