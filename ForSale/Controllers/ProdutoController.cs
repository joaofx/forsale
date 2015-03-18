using System.Web.Mvc;
using ForSale.Models;

namespace ForSale.Controllers
{
    public class ProdutoController : Controller
    {
        [OutputCache(Duration = 3600, VaryByParam = "tag")]
        public ActionResult Lista(string tag = "")
        {
            ViewBag.Tag = tag;
            return View(Products.All(tag));
        }

        [OutputCache(Duration = 3600, VaryByParam = "id")]
        public ActionResult Mostrar(string id)
        {
            return View(Products.ById(id));
        }
    }
}