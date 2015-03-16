using System.Web.Mvc;
using ForSale.Models;

namespace ForSale.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index(string tag = "")
        {
            ViewBag.Tag = tag;
            return View(Products.All(tag));
        }

        public ActionResult Show(string id)
        {
            return View(Products.ById(id));
        }
    }
}