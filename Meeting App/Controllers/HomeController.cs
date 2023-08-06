using Microsoft.AspNetCore.Mvc;

namespace Meeting_App.Controllers
{
    public class HomeController : Controller
    {
        //{controller = Home}/{action=index}/id?
        //loclhost/home => Default
        public IActionResult Index()
        {
            return View();
        }

    }
}
