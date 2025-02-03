using Microsoft.AspNetCore.Mvc;

namespace ShantaLifeInsurance.Controllers
{
    public class CustomerProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
