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
    [Authorize(Roles = "Funcionario")]
    public class FuncionarioController : Controller
    {
        private GerenciadorFuncionario gFuncionario;

        public FuncionarioController()
        {
            this.gFuncionario = new GerenciadorFuncionario();
        }

        //
        // GET: /Funcionario/

        public ActionResult Index()
        {
            return View(this.gFuncionario.ObterTodos());
        }

        //
        // GET: /Funcionario/Details/5

        public ActionResult Details(int id)
        {
            FuncionarioModel funcionarioModel = this.gFuncionario.Obter(id);
            return View(funcionarioModel);
        }

        //
        // GET: /Funcionario/Create

        public ActionResult Create()
        {
            ViewBag.TipoConta = new SelectList(new[]
            {
               new {Valor = "Conta Corrente", Texto = "Conta Corrente"},
               new {Valor = "Conta Poupança", Texto = "Conta Poupança"},
               new {Valor = "Conta Salário", Texto = "Conta Salário"},
               
            }, "Valor", "Texto");
            return View();
        }

        //
        // POST: /Funcionario/Create

        [HttpPost]
        public ActionResult Create(FuncionarioModel funcionarioModel)
        {
            if (ModelState.IsValid)
            {
                gFuncionario.Inserir(funcionarioModel);
                return RedirectToAction("Index");
            }
            return View(funcionarioModel);
        }

        //
        // GET: /Funcionario/Edit/5

        public ActionResult Edit(int id)
        {
            FuncionarioModel funcionarioModel = this.gFuncionario.Obter(id);
            ViewBag.TipoConta = new SelectList(new[]
            {
               new {Valor = "Conta Corrente", Texto = "Conta Corrente"},
               new {Valor = "Conta Poupança", Texto = "Conta Poupança"},
               new {Valor = "Conta Salário", Texto = "Conta Salário"},
               
            }, "Valor", "Texto",funcionarioModel.TipoConta);
            return View(funcionarioModel);
        }

        //
        // POST: /Funcionario/Edit/5

        [HttpPost]
        public ActionResult Edit(FuncionarioModel funcionarioModel)
        {
            if (ModelState.IsValid)
            {
                this.gFuncionario.Editar(funcionarioModel);
                return RedirectToAction("Index");
            }
            return View(funcionarioModel);
        }

        //
        // GET: /Funcionario/Delete/5

        public ActionResult Delete(int id)
        {
            FuncionarioModel funcionarioModel = this.gFuncionario.Obter(id);
            return View(funcionarioModel);
        }

        //
        // POST: /Funcionario/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            this.gFuncionario.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
