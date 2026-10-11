using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesHelloWorld.Pages.Unit4.Pages;

public class U04L01L01Model : PageModel
{
    public string Message { get; set; }

    public void OnGet()
    {
        Message = "Unit 4. Razor Pages - Creating Reusable Models Project";
    }
}
