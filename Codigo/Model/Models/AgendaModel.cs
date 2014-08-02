using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Model.App_GlobalResources;

namespace Model.Models
{
    public class AgendaModel
    {
        [Required(ErrorMessageResourceType = typeof(Mensagens),
            ErrorMessageResourceName = "erro_requerido")]
        [Display(Name = "codigo", ResourceType = typeof(Mensagens))]
        public int IdAgenda { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
            ErrorMessageResourceName = "erro_requerido")]
        [StringLength(50)]
        [Display(Name = "nomeAtividade", ResourceType = typeof(Mensagens))]
        public string Nome { get; set; }

        [StringLength(200)]
        [Display(Name = "descricaoAtividade", ResourceType = typeof(Mensagens))]
        public string Descricao { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
            ErrorMessageResourceName = "erro_requerido")]
        [DataType(DataType.DateTime)]
        public DateTime Data { get; set; }

        public int IdFuncionario { get; set; }
    }
}
