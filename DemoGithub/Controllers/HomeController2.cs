using Microsoft.AspNetCore.Mvc;

namespace DemoGithub.Controllers
{
    public class HomeController2 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
