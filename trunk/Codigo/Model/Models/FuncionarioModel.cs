using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Model.App_GlobalResources;

namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class FuncionarioModel : PessoaModel
    {
        [Required(ErrorMessageResourceType = typeof(Mensagens),
          ErrorMessageResourceName = "erro_requerido")]
        [Display(Name = "codigo", ResourceType = typeof(Mensagens))]
        public int IdFuncionario { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
          ErrorMessageResourceName = "erro_requerido")]
        public int TipoConta { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
            ErrorMessageResourceName = "erro_requerido")]
        [StringLength(50)]
        public string Banco { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
           ErrorMessageResourceName = "erro_requerido")]
        [StringLength(10)]
        public string Agencia { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
           ErrorMessageResourceName = "erro_requerido")]
        [StringLength(10)]
        public string NumeroConta { get; set; }

          
    }
}
