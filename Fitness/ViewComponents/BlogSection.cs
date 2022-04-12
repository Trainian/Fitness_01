using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitness.Entityes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Fitness.ViewComponents
{
    public class BlogSection : ViewComponent
    {
        private readonly ILogger<BlogSection> _logger;

        public BlogSection(ILogger<BlogSection> logger)
        {
            _logger = logger;
        }

        public async Task<IViewComponentResult> InvokeAsync ()
        {
            var blogEntities = GetBlogEntities();
            return View("BlogSection", blogEntities);
        }

        public List<BlogEntity> GetBlogEntities()
        {
            return new List<BlogEntity> { 
                new BlogEntity{Id = 1, BlogName = "Many people sign up for affiliate programs", BlogImages = "img/blog/blog-1.jpg", BlogTags = BlogTagsEnum.Gym},
                new BlogEntity{Id = 2, BlogName = "Does Hydroderm Work",BlogImages = "img/blog/blog-2.jpg", BlogTags = BlogTagsEnum.Gym},
                new BlogEntity{Id = 3, BlogName = "Many people sign up for affiliate programs",BlogImages = "img/blog/blog-3.jpg", BlogTags = BlogTagsEnum.Gym},
                new BlogEntity{Id = 4, BlogName = "Many people sign up for affiliate programs",BlogImages = "img/blog/blog-4.jpg", BlogTags = BlogTagsEnum.Gym, BlogVideo = "https://www.youtube.com/watch?v=X_9VoqR5ojM"},
                new BlogEntity{Id = 5, BlogName = "Your Antibiotic One Day To 10 Day Options",BlogImages = "img/blog/blog-5.jpg", BlogTags = BlogTagsEnum.Gym},
            };
        }
    }
}
