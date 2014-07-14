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
            var tipoEventoLista = ObterTodosParaExibicao(this.gTipoEvento);
            ViewBag.IdTipoEvento = new SelectList(tipoEventoLista, "Id", "NomeExibido");
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
            var tipoEventoLista = ObterTodosParaExibicao(this.gTipoEvento);

            ViewBag.IdTipoEvento = new SelectList(tipoEventoLista, "Id", "NomeExibido", eventoModel.IdTipoEvento);
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

        /// <summary>
        /// Obter todos os tipos de evento cadastrados, personalizados para exibicao
        /// </summary>
        /// <param name="gTipoEvento"></param>
        /// <returns>Lista com dados personalizados para exibicao</returns>
        public List<object> ObterTodosParaExibicao(GerenciadorTipoEvento gTipoEvento)
        {
            var tipoEventos = gTipoEvento.ObterTodos();
            List<object> tipoEventoLista = new List<object>();

            foreach (var tp in tipoEventos)
                tipoEventoLista.Add(new
                {
                    Id = tp.IdTipoEvento,
                    NomeExibido = tp.IdTipoEvento + " - " + tp.Nome
                });

            return tipoEventoLista;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
