using Microsoft.AspNetCore.Mvc;
using NETCoreMVCBlog.Models;

namespace NETCoreMVCBlog.Controllers
{
    public class GonderiController : Controller
    {
        public IActionResult Index()
        {
            Gonderi g1 = new Gonderi() { Aciklama="İlk Post", PaylasmaTarihi=Convert.ToDateTime("13.07.2023"), BegeniSayisi=161};
            return View();
        }
    }
}
