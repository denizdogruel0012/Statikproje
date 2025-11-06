using Microsoft.AspNetCore.Mvc;

namespace Statikproje.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
