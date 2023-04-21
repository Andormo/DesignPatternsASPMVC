using Microsoft.AspNetCore.Mvc;
using Tools;
using Tools.Earn;

namespace DesignPatternsASPMVC.Controllers
{
    public class ProductDetailController : Controller
    {
        public IActionResult Index(decimal total)
        {
            LocalEarnFactory localEarnFactory = new LocalEarnFactory(0.20m);

            IEarn localEarn = localEarnFactory.GetEarn();

            ViewBag.TotalLocal = total + localEarn.Earn(total);

            return View();
        }
    }
}
