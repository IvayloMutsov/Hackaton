﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hackaton.Models
{
    public class Proffessors
    {
        [Required]
        public int ID { get; set; }

        [MaxLength(200)]
        public string FullName { get; set; }

        [Required]
        public string AcademicRank { get; set; }

        public string ScientificFiled { get; set; }

        [Required]
        public string University { get; set; }

        [Required,DefaultValue(0)]
        public int Distance { get; set; }

        public DateTime? PrevParticipationDate { get; set; }

        public DateTime? LastParticipationDate { get; set; }

        [DefaultValue(0)]
        public int ParticipationCounter { get; set; }

        public bool UniIsLocal { get; set; }
        public bool IsReserve { get; set; }
    }
}
