using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Model.App_GlobalResources;

namespace Model.Models
{

    public class PedidoModel
    {
        [Required(ErrorMessageResourceType = typeof(Mensagens),
         ErrorMessageResourceName = "erro_requerido")]
        [Display(Name = "codigo", ResourceType = typeof(Mensagens))]
        public int IdPedido { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
            ErrorMessageResourceName = "erro_requerido")]
        [StringLength(50)]
        public string NomePedido { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
            ErrorMessageResourceName = "erro_requerido")]
        [DataType(DataType.Date)]
        public DateTime DataCriacao { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
         ErrorMessageResourceName = "erro_requerido")]        
        public decimal Valor { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
         ErrorMessageResourceName = "erro_requerido")]
        [StringLength(50)]
        public string StatusPedido { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
          ErrorMessageResourceName = "erro_requerido")]
        [DataType(DataType.Date)]
        public DateTime DataEmissao { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
         ErrorMessageResourceName = "erro_requerido")]
        [StringLength(50)]
        public string StatusContrato { get; set; }

        [Display(Name = "tipoEvento", ResourceType = typeof(Mensagens))]
        public int IdPessoa { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
        ErrorMessageResourceName = "erro_requerido")]
        [StringLength(50)]
        public string NomePessoa { get; set; }

     }
}
