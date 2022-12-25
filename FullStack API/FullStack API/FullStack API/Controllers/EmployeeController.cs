using Microsoft.AspNetCore.Mvc;

namespace FullStack_API.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
