using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LOJADEGAMES.Models;

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
        [HttpPost]

        public ActionResult Index(CLASS_JOGO jogo)
        {
            if (ModelState.IsValid)
            {
                return View("RESULTJOGO", jogo);
            }
            return View(jogo);
        }

        public ActionResult ResulJogo(CLASS_JOGO jogo)
        {
            return View(jogo);
        }
    }
}