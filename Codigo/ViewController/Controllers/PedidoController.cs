using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Service;
using Model.Models;
using System.IO;
using Microsoft.Reporting.WebForms;

namespace ViewController.Controllers
{
    public class PedidoController : Controller
    {
        private GerenciadorPedido gPedido;

        private GerenciadorProduto gProduto;
        private GerenciadorPedidoProduto gPedidoProduto;

        private GerenciadorServico gServico;
        private GerenciadorPedidoServico gPedidoServico;

        private GerenciadorEvento gEvento;
        private GerenciadorPedidoEvento gPedidoEvento;


        public PedidoController()
        { 
            gPedido = new GerenciadorPedido();

            gProduto = new GerenciadorProduto();
            gPedidoProduto = new GerenciadorPedidoProduto();

            gServico = new GerenciadorServico();
            gPedidoServico = new GerenciadorPedidoServico();

            gEvento = new GerenciadorEvento();
            gPedidoEvento = new GerenciadorPedidoEvento();
        }
        
        //GET: /Pedido/

        public ActionResult Index()
        {
            return View(gPedido.ObterTodos());
        }

        //
        // GET: /Pedido/Details/5

        public ActionResult Details(int id)
        {
            return View();
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
