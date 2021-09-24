using LOJADEGAMES.Models;
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
        [HttpPost]

        public ActionResult Index(CLASS_CLI cliente)
        {
            if (ModelState.IsValid)
            {
                return View("ResulCliente", cliente);
            }
            return View(cliente);
        }
    }
}
