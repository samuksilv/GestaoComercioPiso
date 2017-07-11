using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestaoComercioPiso.WebSite.Controllers
{
    public class HomeController : Controller
    {
        [Route("~/")]

        public ActionResult Index()
        {
            return View();
        }

        //[Route("~/Redirecionar")]

        //public ActionResult Redirecionar()
        //{
        //    return RedirectToAction("Index");
        //}

        //[Route("~/Partial")]

        //public ActionResult Partial()
        //{
        //    return PartialView("LoginPartial");
        //}

        //[Authorize]

        [Route("~/sobre")]
        public ActionResult About()
        {
            ViewBag.Message = "Esta é a descrição da minha aplicação.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Minha página de contato.";

            ViewData.Add(new KeyValuePair<string, object>("Mensagem", "mensagem via viewData"));

            return View();
        }
    }
}