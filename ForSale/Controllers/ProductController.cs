using System.Web.Mvc;
using ForSale.Models;

namespace ForSale.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            return View(Products.All());
        }

        public ActionResult Show(string id)
        {
            return View(Products.ById(id));
        }
    }
}