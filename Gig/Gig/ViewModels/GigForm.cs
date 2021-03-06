﻿using Gig.Models;
using System.Collections.Generic;

namespace Gig.ViewModels
{
    public class GigForm
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Genre { get; set; }

        public IEnumerable<Genre> Genres { get; set; }
    }
}