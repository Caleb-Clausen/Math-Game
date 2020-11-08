using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MathGame.Models;

namespace MathGame.Pages
{
    public class AdditionModel : PageModel
    {
        [BindProperty]
        public int firstNumber { get; set; }
        [BindProperty]
        public int secondNumber { get; set; }


        [BindProperty]
        public Additioninfo AdditionMod { get; set; }
      // [BindProperty]
        public string  cool { get; set; }

        [BindProperty]
        public string FirstName { get; set; }

        public void OnGet()
        {     
            if(string.IsNullOrWhiteSpace(FirstName) == true)
            {
                FirstName = "User";
            }
            
            
        }

        public IActionResult OnPost()
        {

            if(ModelState.IsValid == false)
            {
                return Page();

            }

            return RedirectToPage("./Pages/Addition");

        }
    }
}
