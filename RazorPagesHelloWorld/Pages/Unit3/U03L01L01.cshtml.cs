using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesHelloWorld.Pages.Unit3;

public class U03L01L01Model : PageModel
{
    public string Message { get; set; }

    public void OnGet()
    {
        Message = "Unit 3. Layout view in razor pages project";
    }
}
