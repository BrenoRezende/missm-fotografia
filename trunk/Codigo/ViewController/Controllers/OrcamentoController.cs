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
    [Authorize(Roles = "Funcionario")]
    public class OrcamentoController : Controller
    {
        private GerenciadorOrcamento gOrcamento;
        

        public OrcamentoController()
        {
            this.gOrcamento = new GerenciadorOrcamento();            
        }

        public ActionResult Index() 
        {         
            
            var produtos =  gOrcamento.ObterTodosProdutos();
            ViewBag.listaProdutos = produtos;

            var servicos = gOrcamento.ObterTodosServicos();
            ViewBag.listaServicos = servicos;

            var tiposDeEvento = gOrcamento.ObterTodosTiposDeEvento();
            ViewBag.listaTipoDeEventos = tiposDeEvento;


            return View();
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        
    }
}
