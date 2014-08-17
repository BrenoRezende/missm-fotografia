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
    public class SessionController
    {

        public static List<ProdutoModel> ListaProdutosEscolhidos
        {
            get
            {   
                GerenciadorProduto gProduto = new GerenciadorProduto();
                List<ProdutoModel> ListP = (List<ProdutoModel>)HttpContext.Current.Session["_ListaProdutosEscolhidos"];
                if (ListP == null)
                    ListP = gProduto.ObterPorNome("zzz").ToList();

                return ListP;
            }
            set
            {
                HttpContext.Current.Session["_ListaProdutosEscolhidos"] = value;
            }
        }

        public static List<ServicoModel> ListaServicosEscolhidos
        {
            get
            {
                GerenciadorServico gServico = new GerenciadorServico();
                List<ServicoModel> ListS = (List<ServicoModel>)HttpContext.Current.Session["_ListaServicosEscolhidos"];
                if (ListS == null)
                    ListS = gServico.ObterPorNome("zzz").ToList();

                return ListS;


            }
            set
            {
                HttpContext.Current.Session["_ListaServicosEscolhidos"] = value;
            }
        }

        public static List<TipoEventoModel> TipoEventoEscolhido
        {
            get
            {
                GerenciadorTipoEvento gTipoEvento = new GerenciadorTipoEvento();
                List<TipoEventoModel> ListTE = (List<TipoEventoModel>)HttpContext.Current.Session["_TipoEventoEscolhido"];
                if (ListTE == null)
                    ListTE = gTipoEvento.ObterPorNome("zzz").ToList();
                return ListTE;
            }
            set
            {
                HttpContext.Current.Session["_TipoEventoEscolhido"] = value;
            }
        }

    }
}
