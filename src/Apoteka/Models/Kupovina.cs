﻿using System;
using System.Collections.Generic;

namespace Apoteka.Models
{
    public partial class Kupovina
    {
        public int RacunId { get; set; }
        public int LijekId { get; set; }
        public int? Kolicina { get; set; }
        public decimal? Iznos { get; set; }

        public virtual Lijek Lijek { get; set; }
        public virtual Racun Racun { get; set; }
    }
}
