using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LOJADEGAMES.Models;

namespace LOJADEGAMES.Controllers
{
    public class FUNCIONARIOController : Controller
    {
        public ActionResult Index()
        {
            var funcionario = new CLASS_FUNCIONARIO();
            return View(funcionario);
        }
        [HttpPost]
        public ActionResult Index(CLASS_FUNCIONARIO funcionario)
        {
            if (ModelState.IsValid)
            {
                return View("RESULTFUNCIONARIO", funcionario);
            }
            return View(funcionario);
        }
    }
}