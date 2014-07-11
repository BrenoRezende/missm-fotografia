using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Model.App_GlobalResources;


namespace Model.Models
{
    [Serializable]
    public class PedidoModel
    {
        [Required(ErrorMessageResourceType = typeof(Mensagens),
            ErrorMessageResourceName = "erro_requerido")]
        [Display(Name = "codigo", ResourceType = typeof(Mensagens))]
        public int IdPedido { get; set; }

        public DateTime DataCriacao { get; set; }

        public decimal ValorTotal { get; set; }

        public string Status { get; set; }

        public DateTime DataEmicao { get; set; }

        public string StatusContrato { get; set; }

        public int IdPessoa { get; set; }

        public string NomePessoa { get; set; }
    }
}
