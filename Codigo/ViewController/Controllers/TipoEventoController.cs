using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Models;
using Service;
using Microsoft.Reporting.WebForms;

namespace ViewController.Controllers
{
    public class TipoEventoController : Controller
    {

        private GerenciadorTipoEvento gTipoEvento;

        public TipoEventoController()
        {
            gTipoEvento = new GerenciadorTipoEvento();
        }

        // GET: /TipoEvento/

        public ActionResult Index()
        {
            return View(gTipoEvento.ObterTodos());
        }

        
        // GET: /TipoEvento/Details/5


        public ActionResult Details(int id)
        {
            TipoEventoModel tipoEventoModel = gTipoEvento.Obter(id);
            return View(tipoEventoModel);
        }

        //
        // GET: /TipoEvento/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TipoEvento/Create

        [HttpPost]
        public ActionResult Create(TipoEventoModel tipoEventoModel)
        {
            if (ModelState.IsValid)
            {
                gTipoEvento.Inserir(tipoEventoModel);
                return RedirectToAction("Index");
            }
            return View(tipoEventoModel);
        }

        //
        // GET: /TipoEvento/Edit/5

        public ActionResult Edit(int id)
        {
            TipoEventoModel tipoEventoModel = gTipoEvento.Obter(id);
            return View(tipoEventoModel);
        }

        //
        // POST: /TipoEvento/Edit/5

        [HttpPost]
        public ActionResult Edit(TipoEventoModel tipoEventoModel)
        {
            if (ModelState.IsValid)
            {
                gTipoEvento.Editar(tipoEventoModel);
                return RedirectToAction("Index");
            }
            return View(tipoEventoModel);
        }

        //
        // GET: /TipoEvento/Delete/5

        public ActionResult Delete(int id)
        {
            TipoEventoModel tipoEventoModel = gTipoEvento.Obter(id);
            return View(tipoEventoModel);
        }

        //
        // POST: /TipoEvento/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            gTipoEvento.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
