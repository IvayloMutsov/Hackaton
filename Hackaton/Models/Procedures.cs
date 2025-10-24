using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;

namespace Hackaton.Models
{
    public class Procedures
    {
        public int Id { get; set; } 
        public DateTime? Date { get; set; }
        public string ProcedureType { get; set; }
        public int? ProfessorId1 { get; set; }
        public int? ProfessorId2 { get; set; }
        public int? ProfessorId3 { get; set; }
        public int? ProfessorId4 { get; set; }
        public int? ProfessorId5 { get; set; }
        public int? ProfessorId6 { get; set; }
        public int? ProfessorId7 { get; set; }
        public int? ReserveInternalId { get; set; }
        public int? ReserveExternalId { get; set; }
    }
}
