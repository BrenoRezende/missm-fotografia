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
    public class ClienteController : Controller
    {

        private GerenciadorCliente gCliente;

        public ClienteController()
        {
            gCliente = new GerenciadorCliente();
        }

        //
        // GET: /Cliente/

        public ActionResult Index()
        {
            return View(gCliente.ObterTodos());
        }

        //
        // GET: /Cliente/Details/5

        public ActionResult Details(int id)
        {
            ClienteModel clienteModel = gCliente.Obter(id);
            return View(clienteModel);
        }

        //
        // GET: /Cliente/Create

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(ClienteModel clienteModel)
        {
            if (ModelState.IsValid)
            {
                gCliente.Inserir(clienteModel);
                return RedirectToAction("Index");
            }
            return View(clienteModel);
        }

        //
        // GET: /Cliente/Edit/5

        public ActionResult Edit(int id)
        {
            ClienteModel clienteModel = gCliente.Obter(id);
            return View(clienteModel);
        }



        [HttpPost]
        public ActionResult Edit(ClienteModel clienteModel)
        {
            if (ModelState.IsValid)
            {
                gCliente.Editar(clienteModel);
                return RedirectToAction("Index");
            }
            return View(clienteModel);
        }

        //
        // GET: /Cliente/Delete/5

        public ActionResult Delete(int id)
        {
            ClienteModel clienteModel = gCliente.Obter(id);
            return View(clienteModel);
        }


        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gCliente.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
