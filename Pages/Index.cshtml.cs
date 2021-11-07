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
            token = "U85pqiuKCkc3/nKv7pV87JIdT7Uvm6RhqQRHSxCWTpA4W8ysmTFRZWWYK/xRZI86rtxa89Wuptb3oMWszfDeaDYbtlE/ndSzTSK5BLJWPAed/cBMVAvoLw9kKPoWZuaz7DwOBlhwN6+Cmg637JCLSAdB04t89/1O/w1cDnyilFU=";
            AdminUserId = "marsfantasy";
        }

        public IActionResult OnGet()
        {
            return Page();
        }
    }
}
