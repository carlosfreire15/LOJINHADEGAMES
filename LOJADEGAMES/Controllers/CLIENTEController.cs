using LOJADEGAMES.Models;
using LOJADEGAMES.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LOJADEGAMES.Controllers
{
    public class CLIENTEController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            var cliente = new CLASS_CLI();
            return View(cliente);
        }
        Acoes ac = new Acoes();
        [HttpPost]

        public ActionResult Index(CLASS_CLI cliente)
        {
            ac.CadastrarCliente(cliente);
            return View(cliente);
        }
    }
}
