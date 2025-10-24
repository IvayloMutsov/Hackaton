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

            var selectedIds = members.Select(m => m.ID)
                .Concat(reserved.Select(r => r.ID)).ToHashSet();

            foreach (var prof in allProffesors)
            {
                if (prof.LastParticipationDate != prof.PrevParticipationDate)
                {
                    prof.ConsecutiveCounter += 1;
                    prof.PrevParticipationDate = prof.LastParticipationDate;
                    prof.LastParticipationDate = DateTime.Now;
                }
                else
                {
                    prof.ConsecutiveCounter = 0;
                }
            }

            var procedure = new Procedures
            {
                Date = dto.Date,
                ProcedureType = dto.ProcedureType,
                ProfessorId1 = members.ElementAtOrDefault(0)?.ID,
                ProfessorId2 = members.ElementAtOrDefault(1)?.ID,
                ProfessorId3 = members.ElementAtOrDefault(2)?.ID,
                ProfessorId4 = members.ElementAtOrDefault(3)?.ID,
                ProfessorId5 = members.ElementAtOrDefault(4)?.ID,
                ProfessorId6 = members.ElementAtOrDefault(5)?.ID,
                ProfessorId7 = members.ElementAtOrDefault(6)?.ID,
                ReserveInternalId = reserved.ElementAtOrDefault(0)?.ID,
                ReserveExternalId = reserved.ElementAtOrDefault(1)?.ID,
            };
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
