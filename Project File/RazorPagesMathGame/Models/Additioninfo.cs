﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathGame.Models
{
    public class Additioninfo
    {
        public string Answer { get; set; }

        public string  secondNumber { get; set; }

        public string sumNumber { get; set; }

        public Random genorator = new Random();

    }
}
