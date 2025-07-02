using DinoDiner.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IEnumerable<MenuItem> Entrees { get; set; }
        public IEnumerable<MenuItem> Sides { get; set; }
        public IEnumerable<MenuItem> Drinks { get; set; }

        public void OnGet()
        {
            Entrees = Menu.Entrees;
            Sides = Menu.Sides;
            Drinks = Menu.Drinks;
        }
    }
}