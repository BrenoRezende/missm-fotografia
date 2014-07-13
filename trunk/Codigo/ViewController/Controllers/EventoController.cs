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
            gEvento = new GerenciadorEvento();
            gTipoEvento = new GerenciadorTipoEvento();
        }

        // GET: /Evento/

        public ActionResult Index()
        {
            return View(gEvento.ObterTodos());
        }

        //
        // GET: /Evento/Details/5

        public ActionResult Details(int id)
        {
            EventoModel eventoModel = gEvento.Obter(id);
            return View(eventoModel);
        }

        //
        // GET: /Evento/Create

        public ActionResult Create()
        {
            ViewBag.IdTipoEvento = new SelectList(gTipoEvento.ObterTodos(), "IdTipoEvento", "Nome");
            return View();
        }

        //
        // POST: /Evento/Create

        [HttpPost]
        public ActionResult Create(EventoModel eventoModel)
        {
            if (ModelState.IsValid)
            {
                gEvento.Inserir(eventoModel);
                return RedirectToAction("Index");
            }
            return View(eventoModel);
        }

        //
        // GET: /Evento/Edit/5

        public ActionResult Edit(int id)
        {
            EventoModel eventoModel = gEvento.Obter(id);
            ViewBag.IdTipoEvento = new SelectList(gTipoEvento.ObterTodos(), "IdTipoEvento", "Nome", eventoModel.IdTipoEvento);
            return View(eventoModel);
        }

        //
        // POST: /Evento/Edit/5

        [HttpPost]
        public ActionResult Edit(EventoModel eventoModel)
        {
            if (ModelState.IsValid)
            {
                gEvento.Editar(eventoModel);
                return RedirectToAction("Index");
            }
            return View(eventoModel);
        }

        //
        // GET: /Evento/Delete/5

        public ActionResult Delete(int id)
        {
            EventoModel eventoModel = gEvento.Obter(id);
            return View(eventoModel);
        }

        //
        // POST: /Evento/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gEvento.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
