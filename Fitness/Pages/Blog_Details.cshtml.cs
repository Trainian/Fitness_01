using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Fitness.Pages
{
    public class Blog_Details : PageModel
    {
        private readonly ILogger<Blog_Details> _logger;

        public Blog_Details(ILogger<Blog_Details> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
