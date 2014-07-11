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
    public class PedidoController : Controller
    {
        private GerenciadorPedido gPedido;

        public PedidoController()
        {
            gPedido = new GerenciadorPedido();
        }
        
        //
        // GET: /Pedido/

        public ActionResult Index()
        {
            return View(gPedido.ObterTodos());
        }

        //
        // GET: /Pedido/Details/5

        public ActionResult Details(int id)
        {
            PedidoModel pedidoModel = gPedido.Obter(id);
            return View(pedidoModel);
        }

        //
        // GET: /Pedido/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Pedido/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Pedido/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Pedido/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Pedido/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Pedido/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
