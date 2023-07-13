using Microsoft.AspNetCore.Mvc;
using NETCoreMVCBlog.Models;

namespace NETCoreMVCBlog.Controllers
{
    public class YorumController1 : Controller
    {
        public IActionResult Index()
        {
            Yorum y1 = new Yorum() { Yazi="Harika!", YorumTarihi=Convert.ToDateTime("13.07.2023"), YorumBegeni=47};
            return View();
        }
    }
}
