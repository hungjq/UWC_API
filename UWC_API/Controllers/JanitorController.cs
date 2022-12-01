using Microsoft.AspNetCore.Mvc;

namespace UWC_API.Controllers
{
    public class JanitorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
