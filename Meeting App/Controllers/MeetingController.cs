using Microsoft.AspNetCore.Mvc;

namespace Meeting_App.Controllers
{
    public class MeetingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
