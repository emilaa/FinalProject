using Microsoft.AspNetCore.Mvc;

namespace Online_Shop___BackEnd.Areas.AdminArea.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "SuperAdmin, Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
