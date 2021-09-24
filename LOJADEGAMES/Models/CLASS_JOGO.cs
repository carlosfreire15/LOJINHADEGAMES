using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LOJADEGAMES.Models
{
    public class CLASS_JOGO
    {
        [Display(Name = "CÓDIGO DO JOGO")]
        [Required(ErrorMessage = "É OBRIGATÓRIO PREENCHER ESTE CAMPO!")]
        public int COD_JOGO { get; set; }

        [Display(Name = "NOME DO JOGO")]
        [MinLength(2, ErrorMessage = "COLOQUE UM NOME DE JOGO VÁLIDO!")]
        [Required(ErrorMessage = "É OBRIGATÓRIO PREENCHER ESTE CAMPO!")]
        public string NOME_JOGO { get; set; }

        [Display(Name = "VERSÃO DO JOGO")]
        [Required(ErrorMessage = "É OBRIGATÓRIO PREENCHER ESTE CAMPO!")]
        public int VER_JOGO { get; set; }

        [Display(Name = "ESTÚDIO/DESENVOLVEDORA DO JOGO")]
        [MinLength(2, ErrorMessage = "INSIRA UM NOME VÁLIDO (NO MPINIMO 2 CARACTERES)")]
        [Required(ErrorMessage = "É OBRIGATÓRIO PREENCHER ESTE CAMPO!")]
        public string EST_DEV_JOGO { get; set; }

        [Display(Name = "GÊNERO DO JOGO")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "INSIRA UM GÊNERO VÁLIDO")]
        [Required(ErrorMessage = "É OBRIGATÓRIO PREENCHER ESTE CAMPO!")]
        public string GEN_JOGO { get; set; }

        [Display(Name = "CLASSIFI. INDICATIVA DO JOGO")]
        [Range(3, 18, ErrorMessage = "ESTE CAMPO COMPORTO APENAS NÚMEROS ENTRE 3 E 18")]
        [Required(ErrorMessage = "É OBRIGATÓRIO PREENCHER ESTE CAMPO!")]
        public int CLASSIFI_JOGO { get; set; }

        [Display(Name = "PLATAFORMA DO JOGO")]
        [MinLength(2, ErrorMessage = "INSIRA UMA PLATAFORMA VÁLIDA")]
        [Required(ErrorMessage = "É OBRIGATÓRIO PREENCHER ESTE CAMPO!")]
        public string PLATAFORMA_JOGO { get; set; }

        [Display(Name = "ANO DE LANÇAMENTO DO JOGO")]
        [Required(ErrorMessage = "É OBRIGATÓRIO PREENCHER ESTE CAMPO!")]
        public int ANO_JOGO { get; set; }

        [Display(Name = "SINOPSE DO JOGO")]
        [StringLength(1000, MinimumLength = 25, ErrorMessage = "ESCREVA DE 25 A 100 CARACTERES")]
        [Required(ErrorMessage = "É OBRIGATÓRIO PREENCHER ESTE CAMPO!")]
        public string SINOPSE_JOGO { get; set; }
    }
}