using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace pluralsight.Pages.Restaurant
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;

        // public int MyProperty { get; set; }
        public string Message { get; set; }

        public ListModel(IConfiguration config)
        {
        }

        public void OnGet()
        {
            Message = "Hello, World!";
        }
    }
}