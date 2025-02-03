using Microsoft.AspNetCore.Mvc;

namespace ShantaLifeInsurance.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
