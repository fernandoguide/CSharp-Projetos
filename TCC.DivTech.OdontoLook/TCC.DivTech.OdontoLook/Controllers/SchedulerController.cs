using Microsoft.AspNetCore.Mvc;
using TCC.DivTech.OdontoLook.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TCC.DivTech.OdontoLook.Controllers
{
    public class SchedulerController : Controller
    {
        public ActionResult Overview()
        {
            return View(SampleData.Workouts);
        }
    }
}