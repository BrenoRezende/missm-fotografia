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
    public class ClienteModel
    {
        [Required(ErrorMessageResourceType = typeof(Mensagens),
           ErrorMessageResourceName = "erro_requerido")]
        [Display(Name = "codigo", ResourceType = typeof(Mensagens))]
        public int IdCliente { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
            ErrorMessageResourceName = "erro_requerido")]
        [Display(Name = "nome_pessoa", ResourceType = typeof(Mensagens))]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
            ErrorMessageResourceName = "erro_requerido")]
        [Display(Name = "cpf", ResourceType = typeof(Mensagens))]
        [StringLength(11)]
        public string Cpf { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
            ErrorMessageResourceName = "erro_requerido")]
        [Display(Name = "sexo", ResourceType = typeof(Mensagens))]
        [StringLength(1)]
        public string Sexo { get; set; }

         [Required(ErrorMessageResourceType = typeof(Mensagens),
            ErrorMessageResourceName = "erro_requerido")]
         [Display(Name = "data_nascimento", ResourceType = typeof(Mensagens))]
        public DateTime DataNascimento { get; set; }

         [Required(ErrorMessageResourceType = typeof(Mensagens),
             ErrorMessageResourceName = "erro_requerido")]
         [Display(Name = "telefone", ResourceType = typeof(Mensagens))]
         [StringLength(12)]
        public string Telefone { get; set; }

         [Required(ErrorMessageResourceType = typeof(Mensagens),
             ErrorMessageResourceName = "erro_requerido")]
         [Display(Name = "email", ResourceType = typeof(Mensagens))]
         [StringLength(50)]
        public string Email { get; set; }

         [Required(ErrorMessageResourceType = typeof(Mensagens),
             ErrorMessageResourceName = "erro_requerido")]
         [Display(Name = "senha", ResourceType = typeof(Mensagens))]
         [StringLength(15)]
        public string Senha { get; set; }

         [Required(ErrorMessageResourceType = typeof(Mensagens),
             ErrorMessageResourceName = "erro_requerido")]
         [Display(Name = "rua", ResourceType = typeof(Mensagens))]
         [StringLength(20)]
        public string Rua { get; set; }

         [Required(ErrorMessageResourceType = typeof(Mensagens),
             ErrorMessageResourceName = "erro_requerido")]
         [Display(Name = "numero", ResourceType = typeof(Mensagens))]
        public int Numero { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
             ErrorMessageResourceName = "erro_requerido")]
        [Display(Name = "bairro", ResourceType = typeof(Mensagens))]
        public string Bairro { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
             ErrorMessageResourceName = "erro_requerido")]
        [Display(Name = "cidade", ResourceType = typeof(Mensagens))]
        public string Cidade { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
             ErrorMessageResourceName = "erro_requerido")]
        [Display(Name = "estado", ResourceType = typeof(Mensagens))]
        public string Estado { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagens),
             ErrorMessageResourceName = "erro_requerido")]
        [Display(Name = "tipo_pessoa", ResourceType = typeof(Mensagens))]
        [StringLength(1)]
        public string Tipo { get; set; } 
    }
}
