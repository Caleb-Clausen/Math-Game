using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorPagesMathGame.Pages
{
    [Authorize]
    public class StudentPortalModel : PageModel
    {
        private readonly ILogger<StudentPortalModel> _logger;

        public StudentPortalModel(ILogger<StudentPortalModel> logger)
        {
            _logger = logger;
        }

        public string Message { get; private set; } = "PageModel in C#";

        public void OnGet()
        {

        }
       
    }
}
