using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Fitness.Pages
{
    public class Shedule : PageModel
    {
        private readonly ILogger<Shedule> _logger;

        public Shedule(ILogger<Shedule> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
