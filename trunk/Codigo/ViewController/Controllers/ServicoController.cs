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
            gServico = new GerenciadorServico();
        }

        // GET: /Produto/
        public ActionResult Index()
        {
            return View(gServico.ObterTodos());
        }

        //
        // GET: /Servico/Details/5

        public ActionResult Details(int id)
        {
            ServicoModel servicoModel = gServico.Obter(id);
            return View(servicoModel);
        }

        //
        // GET: /Servico/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Servico/Create

        [HttpPost]
        public ActionResult Create(ServicoModel servicoModel)
        {
            if(ModelState.IsValid)
            {
                gServico.Inserir(servicoModel);
                return RedirectToAction("Index");
            }
                return View(servicoModel);
        }
        
        
        //
        // GET: /Servico/Edit/5
 
        public ActionResult Edit(int id)
        {
            ServicoModel servicoModel = gServico.Obter(id);
            return View(servicoModel);
        }

        //
        // POST: /Servico/Edit/5

        [HttpPost]
        public ActionResult Edit(ServicoModel servicoModel)
        {
            if(ModelState.IsValid)
            {
                gServico.Editar(servicoModel);
                return RedirectToAction("Index");
            }
            
            return View(servicoModel);
            
        }

        //
        // GET: /Servico/Delete/5
 
        public ActionResult Delete(int id)
        {
            ServicoModel servicoModel = gServico.Obter(id);
            return View(servicoModel);
        }

        //
        // POST: /Servico/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gServico.Remover(id);
            return RedirectToAction("Index");
         
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
