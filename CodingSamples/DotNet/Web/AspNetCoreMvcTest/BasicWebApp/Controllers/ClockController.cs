using Microsoft.AspNetCore.Mvc;

namespace BasicWebApp.Controllers;

public class ClockController : Controller
{
    public IActionResult Time()
    {
        return Content(DateTime.Now.ToString());
    }
}