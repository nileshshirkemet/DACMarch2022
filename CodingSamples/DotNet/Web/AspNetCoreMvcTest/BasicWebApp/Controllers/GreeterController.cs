using Microsoft.AspNetCore.Mvc;

namespace BasicWebApp.Controllers;

using Services;

public class GreeterController : Controller
{
    public IActionResult Greet(string id, [FromServices] IHitCounter counter)
    {
        int n = counter.CountNext(id);
        ViewBag.Visitor = new { Name = id, Count = n };
        if((n % 2) == 1)
            return View("~/Markup/Welcome.cshtml");
        return View("~/Markup/Hello.cshtml");
    }
}
