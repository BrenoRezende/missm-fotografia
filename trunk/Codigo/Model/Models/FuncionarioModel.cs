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
        [Display(Name = "tipo_conta", ResourceType = typeof(Mensagens))]
        [StringLength(30)]
        public string TipoConta { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
            ErrorMessageResourceName = "erro_requerido")]
        [StringLength(50)]
        public string Banco { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
           ErrorMessageResourceName = "erro_requerido")]
        [StringLength(10)]
        [Display(Name = "agencia", ResourceType = typeof(Mensagens))]
        public string Agencia { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
           ErrorMessageResourceName = "erro_requerido")]
        [StringLength(10)]
        [Display(Name = "numero_conta", ResourceType = typeof(Mensagens))]
        public string NumeroConta { get; set; }

        
  
    }
}
