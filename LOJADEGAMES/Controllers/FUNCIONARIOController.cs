using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LOJADEGAMES.Models;
using LOJADEGAMES.Repositorio;

namespace LOJADEGAMES.Controllers
{
    public class FUNCIONARIOController : Controller
    {
        public ActionResult Index()
        {
            var funcionario = new CLASS_FUNCIONARIO();
            return View(funcionario);
        }
        Acoes ac = new Acoes();
        [HttpPost]
        public ActionResult Index(CLASS_FUNCIONARIO funcionario)
        {
            ac.CadastrarFuncionario(funcionario);
            return View(funcionario);
        }
        public ActionResult ListarFuncionario()
        {
            var ExibirFunc = new Acoes();
            var TodosFunc = ExibirFunc.ListarFuncionario();
            return View(TodosFunc);
        }
    }
}