using System.Diagnostics;
using Hackaton.Data;
using Hackaton.Models;
using Hackaton.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hackaton.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var procedures = await _context.Procedures.ToListAsync();
            var professors = await _context.Proffessors.ToListAsync(); // or Professors if renamed

            var viewModel = procedures.Select(p => new ProcedureViewModel
            {
                Procedure = p,
                Professors = professors
                    .Where(prof =>
                        prof.ID == p.ProfessorId1 ||
                        prof.ID == p.ProfessorId2 ||
                        prof.ID == p.ProfessorId3 ||
                        prof.ID == p.ProfessorId4 ||
                        prof.ID == p.ProfessorId5 ||
                        prof.ID == p.ProfessorId6 ||
                        prof.ID == p.ProfessorId7 ||
                        prof.ID == p.ReserveInternalId ||
                        prof.ID == p.ReserveExternalId)
                    .ToList()
            }).ToList();

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
