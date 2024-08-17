using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace youaresafe.Controllers
{
    [Authorize]
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            // Kullanıcının ayarlarını buradan getirin
            return View();
        }

        [HttpPost]
        public IActionResult ChangeTheme(bool isDarkMode)
        {
            // Tema değiştirme işlemini burada yapın
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult ChangePassword(/* gerekli parametreler */)
        {
            // Şifre değiştirme işlemini burada yapın
            return RedirectToAction("Index");
        }
    }
}


