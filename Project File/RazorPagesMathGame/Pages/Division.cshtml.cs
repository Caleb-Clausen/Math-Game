using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathGame.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MathGame.Pages
{
    public class DivisionModel : PageModel
    {
        [BindProperty]
        public int firstNumber { get; set; }

        private int multiplesOfFirstNumber;
        [BindProperty]
        public int MultiplesOfFirstNumber
        {
            get { return multiplesOfFirstNumber; }
            set { multiplesOfFirstNumber = value; }
        }


        [BindProperty]
        public int secondNumber { get; set; }

        public string Yes = "Correct!";
        public string No = "Try Again";
        public string answerHolder;

        public Divisioninfo DivisionMod = new Divisioninfo();

        // [BindProperty]
        public string cool { get; set; }

        [BindProperty]
        public string FirstName { get; set; }


        public void OnGet()
        {


            if (string.IsNullOrWhiteSpace(FirstName) == true)
            {
                FirstName = DivisionMod.Answer;
            }



        }

        public IActionResult OnPost()
        {
            firstNumber = DivisionMod.genorator.Next(1, 21);
            secondNumber = DivisionMod.genorator.Next(1, 21);
            if (Convert.ToInt32(DivisionMod.Answer) == (firstNumber + secondNumber))
            {
                answerHolder = Yes;

            }
            else { answerHolder = No; }



            return Page();

        }
    }
}
