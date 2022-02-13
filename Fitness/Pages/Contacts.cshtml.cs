using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Fitness.Pages
{
    public class Contacts : PageModel
    {
        private readonly ILogger<Contacts> _logger;

        public Contacts(ILogger<Contacts> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
