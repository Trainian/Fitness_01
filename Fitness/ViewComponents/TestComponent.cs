using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Fitness.ViewComponents
{
    public class TestComponent : ViewComponent
    {
        private readonly ILogger<TestComponent> _logger;

        public TestComponent(ILogger<TestComponent> logger)
        {
            _logger = logger;
        }

        public async Task<IViewComponentResult> InvokeAsync ()
        {
            return View();
        }
    }
}