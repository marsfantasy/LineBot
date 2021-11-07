using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using isRock.LineBot;

namespace LineBot.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private string token;
        private string AdminUserId;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

            
        }

        public IActionResult OnGet()
        {
            return Page();
        }
    }
}
