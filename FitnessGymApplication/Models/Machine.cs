﻿using System.ComponentModel.DataAnnotations.Schema;

namespace GYM_FITNESS.Models
{
    public class Machine
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        [ForeignKey]
        public ICollection<Location> Locations { get; set; }
    }
}