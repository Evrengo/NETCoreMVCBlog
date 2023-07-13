using Microsoft.AspNetCore.Mvc;
using NETCoreMVCBlog.Models;

namespace NETCoreMVCBlog.Controllers
{
    public class KullaniciController : Controller
    {
        public IActionResult Index()
        {
            Kullanici k1 = new Kullanici() { Ad = "Hayri", KullaniciAdi = "Hayri34", Cevrimici=true };
            return View();
        }
    }
}
