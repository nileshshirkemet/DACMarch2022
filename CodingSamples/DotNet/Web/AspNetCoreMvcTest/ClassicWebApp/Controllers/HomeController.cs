using Tourism;
using Microsoft.AspNetCore.Mvc;

namespace ClassicWebApp.Controllers;

public class HomeController : Controller
{
    private ISiteStore _model;

    public HomeController(ISiteStore model)
    {
        _model = model;
    }

    public IActionResult Index()
    {
        var site = _model.Load("CitiZoo");
        return View(site); //~/Views/<controller-name>/<action-name>.cshtml
    }

    [HttpPost]
    public IActionResult Register(string person)
    {
        var site = _model.Load("CitiZoo");
        var visitor = site.GetVisitor(person);
        visitor.Visit();
        _model.Save(site);
        return RedirectToAction("Index");
    }
}
