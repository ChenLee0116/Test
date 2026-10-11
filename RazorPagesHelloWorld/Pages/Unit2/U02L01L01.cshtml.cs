using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesHelloWorld.Pages.Unit2;

public class U02L01L01Model : PageModel
{
    public string Message { get; set; }

    public void OnGet()
    {
        Message = "Unit 2. ASP.NET core 3.0 project file";
    }
}
