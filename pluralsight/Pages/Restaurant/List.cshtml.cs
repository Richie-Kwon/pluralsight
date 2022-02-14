using Microsoft.AspNetCore.Mvc.RazorPages;

namespace pluralsight.Pages.Restaurant
{
    public class List : PageModel
    {

        // public int MyProperty { get; set; }
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Hello, World!";
        }
    }
}