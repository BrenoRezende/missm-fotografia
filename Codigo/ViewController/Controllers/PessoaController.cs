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
            gPessoa = new GerenciadorPessoa();
        }

        // GET: /Produto/
        public ActionResult Index()
        {
            return View(gPessoa.ObterTodos());
        }

        //
        // GET: /Pessoa/Details/5

        public ActionResult Details(int id)
        {
            PessoaModel pessoaModel = gPessoa.Obter(id);
            return View(pessoaModel);
        }

        //
        // GET: /Pessoa/Create

        public ActionResult Create()
        {
            return View();
        } 

        
        [HttpPost]
        public ActionResult Create(PessoaModel pessoaModel)
        {
           if(ModelState.IsValid)
           {
               gPessoa.Inserir(pessoaModel);
               return RedirectToAction("Index");
           }
           return View(pessoaModel);
           
        }
        
        //
        // GET: /Pessoa/Edit/5
 
        public ActionResult Edit(int id)
        {
            PessoaModel pessoaModel = gPessoa.Obter(id);
            return View(pessoaModel);
        }


        [HttpPost]
        public ActionResult Edit(PessoaModel pessoaModel)
        {
            if(ModelState.IsValid)
            {
                gPessoa.Editar(pessoaModel);
                return RedirectToAction("Index");
            }
                return View(pessoaModel);
            
        }

        //
        // GET: /Pessoa/Delete/5
 
        public ActionResult Delete(int id)
        {
            PessoaModel pessoaModel = gPessoa.Obter(id);
            return View(pessoaModel);
        }


        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gPessoa.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
