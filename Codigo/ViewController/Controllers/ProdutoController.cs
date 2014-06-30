using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Models;
using Service;
using Microsoft.Reporting.WebForms;

namespace ViewController.Controllers
{
    public class ProdutoController : Controller
    {

        private GerenciadorProduto gProduto;

        public ProdutoController()
        {
            gProduto = new GerenciadorProduto();
        }

        // GET: /Produto/

        public ActionResult Index()
        {
            return View(gProduto.ObterTodos());
        }

        //
        // GET: /Produto/Details/5

        public ActionResult Details(int id)
        {
            ProdutoModel produtoModel = gProduto.Obter(id);
            return View(produtoModel);
        }

        //
        // GET: /Produto/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Produto/Create

        [HttpPost]
        public ActionResult Create(ProdutoModel produtoModel)
        {
            if (ModelState.IsValid)
            {
                gProduto.Inserir(produtoModel);
                return RedirectToAction("Index");
            }
            return View(produtoModel);
        }
        
        //
        // GET: /Produto/Edit/5
 
        public ActionResult Edit(int id)
        {
            ProdutoModel produtoModel = gProduto.Obter(id);
            return View(produtoModel);
        }

        //
        // POST: /Produto/Edit/5

        [HttpPost]
        public ActionResult Edit(ProdutoModel produtoModel)
        {
            if (ModelState.IsValid)
            {
                gProduto.Editar(produtoModel);
                return RedirectToAction("Index");
            }
                return View(produtoModel);
        }

        //
        // GET: /Produto/Delete/5
 
        public ActionResult Delete(int id)
        {
            ProdutoModel produtoModel = gProduto.Obter(id);
            return View(produtoModel);
        }

        //
        // POST: /Produto/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gProduto.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
