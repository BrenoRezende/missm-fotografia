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
    public class EventoController : Controller
    {

        private GerenciadorEvento gEvento;
        private GerenciadorTipoEvento gTipoEvento;

        public EventoController()
        {
            this.gEvento = new GerenciadorEvento();
            this.gTipoEvento = new GerenciadorTipoEvento();
        }

        // GET: /Evento/

        public ActionResult Index()
        {
            return View(this.gEvento.ObterTodos());
        }


        // GET: /Evento/Details/5

        public ActionResult Details(int id)
        {
            EventoModel eventoModel = this.gEvento.Obter(id);
            return View(eventoModel);
        }


        // GET: /Evento/Create

        public ActionResult Create()
        {
            ViewBag.IdTipoEvento = new SelectList(this.gTipoEvento.ObterTodos(), "IdTipoEvento", "Nome");
            return View();
        }


        // POST: /Evento/Create

        [HttpPost]
        public ActionResult Create(EventoModel eventoModel)
        {
            if (ModelState.IsValid)
            {
                this.gEvento.Inserir(eventoModel);
                return RedirectToAction("Index");
            }
            return View(eventoModel);
        }


        // GET: /Evento/Edit/5

        public ActionResult Edit(int id)
        {
            EventoModel eventoModel = this.gEvento.Obter(id);
            ViewBag.IdTipoEvento = new SelectList(this.gTipoEvento.ObterTodos(), "IdTipoEvento", "Nome", eventoModel.IdTipoEvento);
            return View(eventoModel);
        }


        // POST: /Evento/Edit/5

        [HttpPost]
        public ActionResult Edit(EventoModel eventoModel)
        {
            if (ModelState.IsValid)
            {
                this.gEvento.Editar(eventoModel);
                return RedirectToAction("Index");
            }
            return View(eventoModel);
        }


        // GET: /Evento/Delete/5

        public ActionResult Delete(int id)
        {
            EventoModel eventoModel = this.gEvento.Obter(id);
            return View(eventoModel);
        }


        // POST: /Evento/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            this.gEvento.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
