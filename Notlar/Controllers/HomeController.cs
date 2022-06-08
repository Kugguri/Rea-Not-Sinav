using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Notlar.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Notlar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NotDbContext _context;

        public HomeController(ILogger<HomeController> logger, NotDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Notlar()
        {
            List<Not> list = _context.Notlar.ToList();
            return View(list);
        }
        public async Task<IActionResult> AddNot(Not not)
        {
            await _context.AddAsync(not);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Notlar));
        }
        public async Task<IActionResult> DeleteNot(int? Id)
        {
            Not not = await _context.Notlar.FindAsync(Id);
            _context.Remove(not);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Notlar));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
