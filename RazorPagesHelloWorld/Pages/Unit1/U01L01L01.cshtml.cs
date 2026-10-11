using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesHelloWorld.Pages.Unit1;

public class U01L01L01Model : PageModel
{
    public string Message { get; set; }

    public void OnGet()
    {
        Message = "Unit 1. ASP.NET Core razor pages introduction";
    }
}
