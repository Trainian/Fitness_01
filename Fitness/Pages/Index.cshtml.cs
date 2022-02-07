using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fitness.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        ViewData["ClassSection_Title"] = "Choose Your Program";
        ViewData["ClassSection_Text"] = "Our Crossfit experts can help you discover new training techniques and exercises that offer a dynamic and efficient full-body workout.";
    }
}
