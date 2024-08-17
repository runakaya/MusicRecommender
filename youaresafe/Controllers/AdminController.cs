using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
namespace youaresafe.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

}
