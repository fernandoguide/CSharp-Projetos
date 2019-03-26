using Microsoft.AspNetCore.Mvc;

namespace TCC_DivTech_OdontoLook.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
     
    }
}
