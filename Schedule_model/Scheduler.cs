﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_model
{
    public class Scheduler
    {
        public long Id { get; set; }
        public Discipline Discipline { get; set; }
        public Discipline_form Discipline_form { get; set; }
        public Place Place { get; set; }
        public Teacher Teacher { get; set; }
        public Group Group { get; set; }
        public DateTime Date { get; set; }
    }
}