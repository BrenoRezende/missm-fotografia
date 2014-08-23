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
    public class ServicoModel
    {
        [Required(ErrorMessageResourceType = typeof(Mensagens),
            ErrorMessageResourceName = "erro_requerido")]
        [Display(Name = "codigo", ResourceType = typeof(Mensagens))]
        public int IdServico { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
            ErrorMessageResourceName = "erro_requerido")]
        [Display(Name = "tipo_servico", ResourceType = typeof(Mensagens))]
        [StringLength(50)]
        public string NomeServico { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
            ErrorMessageResourceName = "erro_requerido")]
        [Display(Name = "nome_parceiro", ResourceType = typeof(Mensagens))]
        [StringLength(50)]
        public string NomeParceiro { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
            ErrorMessageResourceName = "erro_requerido")]
        [Display(Name = "telefone_parceiro", ResourceType = typeof(Mensagens))]
        [StringLength(50)]
        public string TelefoneParceiro { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
            ErrorMessageResourceName = "erro_requerido")]
        [Display(Name = "valor_servico", ResourceType = typeof(Mensagens))]
        public decimal ValorServico { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
            ErrorMessageResourceName = "erro_requerido")]
        [Display(Name = "valor_cobrado_ao_cliente", ResourceType = typeof(Mensagens))]
        public decimal ValorCobradoAoCliente { get; set; }

    }
}
