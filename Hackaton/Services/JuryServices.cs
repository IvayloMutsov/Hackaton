using Hackaton.Data;

namespace Hackaton.Services
{
    public class JuryServices
    {
        private readonly ApplicationDbContext _context;

        public JuryServices(ApplicationDbContext context)
        {
            _context = context;
        }


    }
}
