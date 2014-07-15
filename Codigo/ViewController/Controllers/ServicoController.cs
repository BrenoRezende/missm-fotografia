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
    public class ServicoController : Controller
    {

        private GerenciadorServico gServico;

        public ServicoController()
        {
            this.gServico = new GerenciadorServico();
        }

        // GET: /Produto/
        public ActionResult Index()
        {
            return View(this.gServico.ObterTodos());
        }


        // GET: /Servico/Details/5

        public ActionResult Details(int id)
        {
            ServicoModel servicoModel = this.gServico.Obter(id);
            return View(servicoModel);
        }


        // GET: /Servico/Create

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(ServicoModel servicoModel)
        {
            if (ModelState.IsValid)
            {
                this.gServico.Inserir(servicoModel);
                return RedirectToAction("Index");
            }
            return View(servicoModel);
        }



        // GET: /Servico/Edit/5

        public ActionResult Edit(int id)
        {
            ServicoModel servicoModel = this.gServico.Obter(id);
            return View(servicoModel);
        }


        [HttpPost]
        public ActionResult Edit(ServicoModel servicoModel)
        {
            if (ModelState.IsValid)
            {
                this.gServico.Editar(servicoModel);
                return RedirectToAction("Index");
            }

            return View(servicoModel);

        }


        // GET: /Servico/Delete/5

        public ActionResult Delete(int id)
        {
            ServicoModel servicoModel = this.gServico.Obter(id);
            return View(servicoModel);
        }



        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            this.gServico.Remover(id);
            return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
