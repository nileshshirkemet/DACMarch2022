using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace ClassicWebApp.Pages;

using Data;

[Authorize]
[ResponseCache(NoStore = true)]
public class DetailModel : PageModel
{
    private ShopDbContext _db;

    public DetailModel(ShopDbContext db) => _db = db;

    public Customer LoggedCustomer { get; set; }

    public void OnGet()
    {
        LoggedCustomer = _db.Customers.Find(User.Identity.Name);
        _db.Entry(LoggedCustomer).Collection(e => e.Orders).Load();
    }

    public async Task<IActionResult> OnGetLogoutAsync()
    {
        await HttpContext.SignOutAsync();
        return RedirectToPage("Index");
    }
}
