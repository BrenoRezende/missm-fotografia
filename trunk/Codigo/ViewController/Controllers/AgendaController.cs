using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Model.Models;
using Model;
using Service;
using Microsoft.Reporting.WebForms;


namespace ViewController.Controllers
{
    [Authorize]
    public class AgendaController : Controller
    {

        private GerenciadorEvento gEvento;
        private GerenciadorAgenda gAgenda;

        public AgendaController()
        {
            this.gEvento = new GerenciadorEvento();
            this.gAgenda = new GerenciadorAgenda();
        }

        // GET: /Agenda/

        public ActionResult Index()
        {
            int id = Convert.ToInt32(Membership.GetUser().ProviderUserKey.ToString());
            return View(this.gAgenda.ObterPorUsuario(id));
        }
        
        // GET: /Agenda/AgendaEventos

        public ActionResult AgendaEventos()
        {
            return View(this.gEvento.ObterTodos());
        }

        // GET: /Agenda/Details/5

        public ActionResult Details(int id)
        {
            AgendaModel agendaModel = this.gAgenda.Obter(id);
            return View(agendaModel);
        }

        // GET: /Agenda/Create

        public ActionResult Create()
        {
            return View();
        } 

        // POST: /Agenda/Create

        [HttpPost]
        public ActionResult Create(AgendaModel agendaModel)
        {
            if (ModelState.IsValid)
            {
                string id = Membership.GetUser().ProviderUserKey.ToString();
                agendaModel.IdUsers = Convert.ToInt32(id);
                this.gAgenda.Inserir(agendaModel);
                return RedirectToAction("Index");
            }
            return View(agendaModel);
        }
        
        // GET: /Agenda/Edit/5
 
        public ActionResult Edit(int id)
        {
            AgendaModel agendaModel = this.gAgenda.Obter(id);
            return View(agendaModel);
        }

        // POST: /Agenda/Edit/5

        [HttpPost]
        public ActionResult Edit(AgendaModel agendaModel)
        {
            if (ModelState.IsValid)
            {
                this.gAgenda.Editar(agendaModel);
                return RedirectToAction("Index");
            }
            return View(agendaModel);
        }

        // GET: /Agenda/Delete/5
 
        public ActionResult Delete(int id)
        {
            AgendaModel agendaModel = this.gAgenda.Obter(id);
            return View(agendaModel);
        }

        // POST: /Agenda/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            this.gAgenda.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
