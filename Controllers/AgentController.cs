using Microsoft.AspNetCore.Mvc;

namespace ShantaLifeInsurance.Controllers
{
    public class AgentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
