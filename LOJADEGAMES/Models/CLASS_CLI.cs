using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace LOJADEGAMES.Models
{
    public class CLASS_CLI
    {
        [Display(Name = "NOME DO CLIENTE")]
        [StringLength(50, MinimumLength=2, ErrorMessage ="ESCREVA UM NOME ENTRE 2 E 50 CARACTERES.")]
        [Required(ErrorMessage="É OBRIGATÓRIO PREENCHER ESTE CAMPO!")]
        public string NOME_CLIENTE{ get; set; }

        [Display(Name = "CPF DO CLIENTE")]
        [StringLength(14, MinimumLength=14, ErrorMessage = "ESCREVA UM CPF VÁLIDO.")]
        [Required(ErrorMessage = "É OBRIGATÓRIO PREENCHER ESTE CAMPO!")]
        public string CPF_CLIENTE { get; set; }

        [Display(Name = "DATA DE NASCIMENTO DO CLIENTE")]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}", ApplyFormatInEditMode=true)]
        [Required(ErrorMessage = "É OBRIGATÓRIO PREENCHER ESTE CAMPO!")]
        public DateTime DATA_NASC_CLIENTE
        {
            get
            {
                return this.dtNascCLIENTE.HasValue
                       ? this.dtNascCLIENTE.Value
                       : DateTime.Now;
            }

            set
            {
                this.dtNascCLIENTE = value;

            }
        }
        private DateTime? dtNascCLIENTE = null;

        [Display(Name = "EMAIL DO CLIENTE")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "O formato do email está incorreto")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "COLOQUE UM EMAIL ENTRE 10 E 100 CARACTERES")]
        [Required(ErrorMessage = "É OBRIGATÓRIO PREENCHER ESTE CAMPO!")]
        public string EMAIL_CLIENTE { get; set; }

        [Display(Name = "CELULAR DO CLIENTE")]
        [Required(ErrorMessage = "É OBRIGATÓRIO PREENCHER ESTE CAMPO!")]
        public long CEL_CLIENTE { get; set; }

        [Display(Name = "Endereço do Cliente")]
        [MinLength(6, ErrorMessage = "O campo deve conter o mínimo entre 6 caracteres")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string END_CLIENTE { get; set; }


    }
}