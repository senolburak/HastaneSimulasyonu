﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HastaneSimulasyonu.UI.Models
{
    public class Hasta
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Sikayet { get; set; }
        public List<Randevu> Randevular { get; set; }
    }
}
