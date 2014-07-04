using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Model.Models;
using Data;

namespace Service
{
    class GerenciadorServico
    {
        private IUnitOfWork unitOfWork;
        private bool shared;

        public GerenciadorServico()
        {
            this.unitOfWork = new IUnitOfWork();
            shared = false;
        }
     
    }
}
