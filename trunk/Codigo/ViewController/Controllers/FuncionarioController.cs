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
    public class FuncionarioController : Controller
    {
        private GerenciadorFuncionario gFuncionario;

        public FuncionarioController()
        {
            gFuncionario = new GerenciadorFuncionario();
        }

        //
        // GET: /Funcionario/

        public ActionResult Index()
        {
            return View(gFuncionario.ObterTodos());
        }

        //
        // GET: /Funcionario/Details/5

        public ActionResult Details(int id)
        {
            FuncionarioModel funcionarioModel = gFuncionario.Obter(id);
            return View(funcionarioModel);
        }

        //
        // GET: /Funcionario/Create

        public ActionResult Create()
        {
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
            FuncionarioModel funcionarioModel = gFuncionario.Obter(id);
            return View(funcionarioModel);
        }

        //
        // POST: /Funcionario/Edit/5

        [HttpPost]
        public ActionResult Edit(FuncionarioModel funcionarioModel)
        {
            if (ModelState.IsValid)
            {
                gFuncionario.Editar(funcionarioModel);
                return RedirectToAction("Index");
            }
            return View(funcionarioModel);
        }

        //
        // GET: /Funcionario/Delete/5

        public ActionResult Delete(int id)
        {
            FuncionarioModel funcionarioModel = gFuncionario.Obter(id);
            return View(funcionarioModel);
        }

        //
        // POST: /Funcionario/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gFuncionario.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
