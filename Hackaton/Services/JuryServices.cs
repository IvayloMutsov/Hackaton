using Hackaton.Data;
using Hackaton.Models;

namespace Hackaton.Services
{
    public class JuryServices
    {
        private readonly ApplicationDbContext _context;

        public JuryServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public(List<Proffessors> Members, List<Proffessors> Reserved) SelectJuryMembers(Procedures procedure)
        {
            var all = _context.Proffessors.ToList();
            var local = _context.Proffessors.Where(l => l.UniIsLocal == true).ToList();
            var external = _context.Proffessors
                .Where(l => l.UniIsLocal == false)
                .OrderByDescending(l => l.Distance)
                .ToList();

            int totalMembers = procedure.ProcedureType switch
            {
                "доктор" => 5,
                "доцент" => 7,
                "доктор на науките" or "ДН" => 7,
                "професор" => 7,
                _ => 7
            };

            int minProf = procedure.ProcedureType switch
            {
                "доктор" => 1,
                "доцент" => 3,
                "доктор на науките" or "ДН" => 3,
                "професор" => 4,
                _ => 3
            };

            int minExt = procedure.ProcedureType switch
            {
                "доктор" => 3,
                "доцент" => 3,
                "доктор на науките" or "ДН" => 4,
                "професор" => 3,
                _ => 3
            };

            
        }
    }
}
