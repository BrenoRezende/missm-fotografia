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
    public class PessoaController : Controller
    {
        
        private GerenciadorPessoa gPessoa;

        public PessoaController()
        {
            this.gPessoa = new GerenciadorPessoa();
        }
        

        // GET: /Cliente/

        public ActionResult Index()
        {
            return View(this.gPessoa.ObterTodos());
        }


        // GET: /Cliente/Details/5

        public ActionResult Details(int id)
        {
            PessoaModel pessoaModel = this.gPessoa.Obter(id);
            return View(pessoaModel);
        }


        // GET: /Cliente/Create

        public ActionResult Create()
        {
            return View();
        } 


        [HttpPost]
        public ActionResult Create(PessoaModel pessoaModel)
        {
            if (ModelState.IsValid)
            {
                this.gPessoa.Inserir(pessoaModel);
                return RedirectToAction("Index");
            }
            return View(pessoaModel);
        }
        

        // GET: /Cliente/Edit/5
 
        public ActionResult Edit(int id)
        {
            PessoaModel pessoaModel = this.gPessoa.Obter(id);
            return View(pessoaModel);
        }



        [HttpPost]
        public ActionResult Edit(PessoaModel pessoaModel)
        {
            if (ModelState.IsValid)
            {
                this.gPessoa.Editar(pessoaModel);
                return RedirectToAction("Index");
            }
            return View(pessoaModel);
        }


        // GET: /Cliente/Delete/5
 
        public ActionResult Delete(int id)
        {
            PessoaModel pessoaModel = this.gPessoa.Obter(id);
            return View(pessoaModel);
        }


        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            this.gPessoa.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
