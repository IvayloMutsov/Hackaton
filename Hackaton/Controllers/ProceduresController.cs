using Hackaton.Data;
using Hackaton.Models;
using Hackaton.Services;
using Microsoft.AspNetCore.Mvc;

namespace Hackaton.Controllers
{
    public class ProceduresController : Controller
    {
        private readonly JuryServices _juryServices;
        private readonly ApplicationDbContext _context;

        public ProceduresController(JuryServices juryServices, ApplicationDbContext context)
        {
            _juryServices = juryServices;
            _context = context;
        }

        public IActionResult CreateProcedure([FromBody] Procedures dto)
        {
            var allProffesors = _context.Proffessors.ToList();
            var(members, reserved)= _juryServices.SelectJuryMembers(dto);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
