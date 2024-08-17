using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using youaresafe.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace youaresafe.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProfileController(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var photos = await _context.Photos
                .Where(p => p.UserId == userId)
                .OrderByDescending(p => p.UploadedAt)
                .ToListAsync();

            return View(photos);
        }
    }


}




