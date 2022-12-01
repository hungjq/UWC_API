using Microsoft.AspNetCore.Mvc;

namespace UWC_API.Controllers
{
    public class VehicleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
