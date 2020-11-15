using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MathGame.Models
{
    public class Additioninfo
    {
        [BindProperty]
        public string Answer { get; set; }

        public string  secondNumber { get; set; }

        public string sumNumber { get; set; }

        public Random genorator = new Random();

    }
}
