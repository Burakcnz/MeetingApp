using Microsoft.AspNetCore.Mvc;
using ToplantıKatılımUygulaması.Models;


namespace ToplantıKatılımUygulaması.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var result=_context.ApplyModels.Count();
            ViewData["KatilimciSayisi"]=result;
            return View();
        }  
    }
}
