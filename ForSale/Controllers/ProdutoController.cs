using System.Web.Mvc;
using ForSale.Models;

namespace ForSale.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Lista(string tag = "")
        {
            ViewBag.Tag = tag;
            return View(Products.All(tag));
        }

        public ActionResult Mostrar(string id)
        {
            return View(Products.ById(id));
        }
    }
}