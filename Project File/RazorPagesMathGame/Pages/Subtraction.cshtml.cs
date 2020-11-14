using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MathGame.Pages
{
    public class SubtractionModel : PageModel
    {
        public string MyProperty2 { get; set; } = "hello";
        public void Displaymessage()
        {
           // WriteOnlyStream("hello and welcome!");
        }
        public void OnGet()
        {
        }
    }
}
