using Microsoft.AspNetCore.Mvc;
using System.Linq;
using youaresafe.Data;
using youaresafe.Models;

namespace youaresafe.Controllers
{
    
    public class AboutController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AboutController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
          
            return View();
        }

    }
}
