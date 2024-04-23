using Microsoft.AspNetCore.Mvc;
using ToplantıKatılımUygulaması.Models;

namespace ToplantıKatılımUygulaması.Controllers
{
    public class MeetingController : Controller
    {
        private readonly AppDbContext _context;

        public MeetingController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var result=_context.ApplyModels.ToList();
            return View(result);
        }

        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(ApplyModel model)
        {
            if (ModelState.IsValid)
            {
                _context.ApplyModels.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
