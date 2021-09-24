using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LOJADEGAMES.Models
{
    public class CLASS_FUNCIONARIO
    {
        [Display(Name = "CODIGO DO FUNCIONÁRIO")]
        [Required(ErrorMessage = "É OBRIGATÓRIO PREENCHER ESTE CAMPO!")]
        public int COD_FUNC { get; set; }

        [Display(Name = "NOME DO FUNCIONÁRIO")]
        [StringLength(70, MinimumLength = 2, ErrorMessage = "INSIRA UM NOME VÁLIDO, ENTRE 2 E 70 CARACTERES")]
        [Required(ErrorMessage = "É OBRIGATÓRIO PREENCHER ESTE CAMPO!")]
        public string NOME_FUNC { get; set; }

        [Display(Name = "CPF DO FUNCIONÁRIO")]
        [StringLength(14, MinimumLength = 14, ErrorMessage = "CPF INCORRETO")]
        [Required(ErrorMessage = "É OBRIGATÓRIO PREENCHER ESTE CAMPO!")]
        public string CPF_FUNC { get; set; }

        [Display(Name = "RG DO FUNCIONÁRIO")]
        [MaxLength(14, ErrorMessage = "RG INCORRETO")]
        [Required(ErrorMessage = "É OBRIGATÓRIO PREENCHER ESTE CAMPO!")]
        public string RG_FUNC { get; set; }

        [Display(Name = "DATA DE NASCIMENTO DO FUNCIONÁRIO")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "É OBRIGATÓRIO PREENCHER ESTE CAMPO!")]
        public DateTime DATA_NASC_FUNC
        {
            get
            {
                return this.dtNasc_FUNC.HasValue
                    ? this.dtNasc_FUNC.Value
                    : DateTime.Now;
            }


            set
            {
                this.dtNasc_FUNC = value;
            }

        }
        private DateTime? dtNasc_FUNC = null;

        [Display(Name = "ENDEREÇO DO FUNCIONÁRIO")]
        [MinLength(6, ErrorMessage = "ADICIONE UM ENDEREÇO COM NO MÍNIMO 6 CARACTERES")]
        [Required(ErrorMessage="É OBRIGATÓRIO PREENCHER ESTE CAMPO!")]
        public string END_FUNC { get; set; }

        [Display(Name = "CELULAR DO FUNCIONÁRIO")]
        [Required(ErrorMessage = "É OBRIGATÓRIO PREENCHER ESTE CAMPO!")]
        public long CEL_FUNC { get; set; }

        [Display(Name = "EMAIL DO FUNCIONÁRIO")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "O EMAIL ESTÁ INCORRETO")]
        [StringLength(110, MinimumLength = 12, ErrorMessage = "O campo deve conter o mínimo entre 12 a 110 caracteres")]
        [Required(ErrorMessage = "É OBRIGATÓRIO PREENCHER ESTE CAMPO!")]
        public string EMAIL_FUNC { get; set; }

        [Display(Name = "CARGO DO FUNCIONÁRIO")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "O CARGO DEVE SER DESCRITE DE 5 A 25 CARACTERES")]
        [Required(ErrorMessage = "É OBRIGATÓRIO PREENCHER ESTE CAMPO!")]
        public string CARGO_FUNC{ get; set; }
    }
}