using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Security.Claims;
using System.Threading.Tasks;
using System;
using youaresafe.Data;
using youaresafe.Models;
using System.Linq;
using youaresafe.Services;
using Microsoft.AspNetCore.Identity;

namespace youaresafe.Controllers
{
    [Authorize]
    public class PhotoController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SpotifyService _spotifyService;

        public PhotoController(IWebHostEnvironment webHostEnvironment, ApplicationDbContext context, UserManager<ApplicationUser> userManager, SpotifyService spotifyService)
        {
            _webHostEnvironment = webHostEnvironment;
            _context = context;
            _userManager = userManager;
            _spotifyService = spotifyService;
        }

        [HttpGet]
        public IActionResult Upload()
        {
            return View("Home/Anasayfa");
        }

        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile photo)
        {
            if(photo != null && photo.Length > 0)
        {
                var uploads = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");
                if (!Directory.Exists(uploads))
                {
                    Directory.CreateDirectory(uploads);
                }

                var filePath = Path.Combine(uploads, photo.FileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await photo.CopyToAsync(stream);
                }

                string songRecommendation = await _spotifyService.GetSongRecommendationAsync();

                return Json(new { photoPath = "/uploads/" + photo.FileName, songRecommendation
                });
            }


            return BadRequest("Fotoğraf yükleme başarısız oldu.");
        }

    }


}
