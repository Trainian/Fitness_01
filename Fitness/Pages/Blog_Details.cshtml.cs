using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Fitness.Data;
using Fitness.Entityes;
using Microsoft.AspNetCore.Components;

namespace Fitness.Pages
{
    public class Blog_Details : PageModel
    {
        private readonly ILogger<Blog_Details> _logger;
        private IDbContext _db;
        private BlogEntity entity;

        public Blog_Details(ILogger<Blog_Details> logger, IDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public BlogEntity Entity { get => entity; set => entity = value; }

        public async Task<IActionResult> OnGetAsync(int idBlog)
        {
            entity = await _db.GetBlogEntityById(idBlog);
            return Page();
        }
    }
}
