﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Flamingo_Airways.Models
{
    public class TicketModel
    {
        public int rid { get; set; }
        public string flightno { get; set; }
        public DateTime rdate { get; set; }
        public decimal amount { get; set; }
        public string arrivalcity { get; set; }
        public string departcity { get; set; }
        public TimeSpan arrivaltime { get; set; }
        public TimeSpan departtime{ get; set; }
        public int nooftickets { get; set; }
        public string userid { get; set; }

    }
}