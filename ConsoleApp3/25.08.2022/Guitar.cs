﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Guitar : Instrument
    {
        public string Color { get; set; }
        public string Material { get; set; }
        public override void Sound()
        {
            throw new NotImplementedException();
        }
    }
}
