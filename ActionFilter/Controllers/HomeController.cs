using ActionFilter.Filters;
using Microsoft.AspNetCore.Mvc;

namespace ActionFilter.Controllers
{
    public class HomeController : Controller
    {
        [ServiceFilter(typeof(LogFilters))]
        public IActionResult Index()
        {
            return View();
        }
    }
}
