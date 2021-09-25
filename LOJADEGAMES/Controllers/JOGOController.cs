using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LOJADEGAMES.Models;
using LOJADEGAMES.Repositorio;

namespace LOJADEGAMES.Controllers
{
    public class JOGOController : Controller
    {
        // GET: JOGO
        public ActionResult Index()
        {
            var jogo = new CLASS_JOGO();
            return View(jogo);
        }
        Acoes ac = new Acoes();
        [HttpPost]

        public ActionResult Index(CLASS_JOGO jogo)
        {
                ac.CadastrarJogo(jogo);
                return View(jogo);
        }
    }
}