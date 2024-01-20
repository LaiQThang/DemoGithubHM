using Microsoft.AspNetCore.Mvc;

namespace DemoGithub.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
