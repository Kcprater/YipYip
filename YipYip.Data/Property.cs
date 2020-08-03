﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YipYip.Data
{
    public class Property
    {
        [Key]
        public int PropertyId { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int NumOfBeds { get; set; }
        [Required]
        public string Desc { get; set; }
        [Required]
        public double WeekDayRate { get; set; }
        [Required]
        public double WeekendRate { get; set; }
        public int Rating { get; set; }
        public Location PropertyLocation { get; set; }

        [ForeignKey(nameof(OwnerId))]
        public int OwnerId { get; set; }
        public virtual Owner Owner { get; set; }

        public virtual ICollection<Attraction> Attraction { get; set; } = new List<Attraction>();
    }
}