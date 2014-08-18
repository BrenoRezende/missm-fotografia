﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Service;
using Model.Models;
using System.IO;
using Microsoft.Reporting.WebForms;
using System.Web.Helpers;

namespace ViewController.Controllers
{
    [Authorize(Roles = "Funcionario")]
    public class PedidoController : Controller
    {
        private GerenciadorPedido gPedido;

        private GerenciadorPessoa gCliente;

        private GerenciadorProduto gProduto;
        private GerenciadorPedidoProduto gPedidoProduto;

        private GerenciadorServico gServico;
        private GerenciadorPedidoServico gPedidoServico;

        private GerenciadorEvento gEvento;
        private GerenciadorPedidoEvento gPedidoEvento;


        public PedidoController()
        { 
            gPedido = new GerenciadorPedido();

            gCliente = new GerenciadorPessoa();

            gProduto = new GerenciadorProduto();
            gPedidoProduto = new GerenciadorPedidoProduto();

            gServico = new GerenciadorServico();
            gPedidoServico = new GerenciadorPedidoServico();

            gEvento = new GerenciadorEvento();
            gPedidoEvento = new GerenciadorPedidoEvento();
        }
        
        //GET: /Pedido/

        public ActionResult SalvarOrcamento()
        {
            ViewBag.IdCliente = new SelectList(gCliente.ObterTodos(), "IdPessoa", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult SalvarOrcamento(PedidoModel pedidoModel)
        {
            if (pedidoModel.IdPessoa > 0)
            {
                pedidoModel.DataEmissao = DateTime.Now;
                pedidoModel.StatusPedido = "Orcamento";
                pedidoModel.StatusContrato = "Sem Contrato";

                int idPedido = gPedido.Inserir(pedidoModel);
                

                PedidoProdutoModel pedidoProdutoModel = new PedidoProdutoModel();
                pedidoProdutoModel.IdPedido = idPedido;
                List<ProdutoModel> listaProdutos = SessionController.ListaProdutosEscolhidos;

                foreach (ProdutoModel pM in listaProdutos)
                {
                    pedidoProdutoModel.IdProduto = pM.IdProduto;
                 
                    gPedidoProduto.Inserir(pedidoProdutoModel);        
                    
                }


                return RedirectToAction("Index", "Orcamento");
            }

            return View(pedidoModel);

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

        /// <summary>
        /// Obter todos os produtos cadastrados, personalizados para exibicao
        /// </summary>
        /// <param name="gProduto"></param>
        /// <returns>Lista com dados personalizados para exibicao</returns>
        public List<object> ObterTodosParaExibicao(GerenciadorProduto gPro)
        {
            var tipoProduto = gPro.ObterTodos();
            List<object> tipoProdutoLista = new List<object>();

            foreach (var tp in tipoProduto)
                tipoProdutoLista.Add(new
                {
                    Id = tp.IdProduto,
                    NomeExibido = tp.Nome + "    |    " + tp.NumeroDePaginas + "     |   " + tp.Formato + "    |    " +
                    tp.NumeroDeImagens + "    |    " + tp.ValorDoProduto 
                });

            return tipoProdutoLista;
        }
    }
}