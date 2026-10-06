using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesHelloWorld.Pages;

public class U02L01L01Model : PageModel
{
    public string Message { get; set; }

    public void OnGet()
    {
        Message = "1. Lab 1. ASP.NET core 3.0 project file";
    }
}
