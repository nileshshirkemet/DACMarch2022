using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace ClassicWebApp.Pages;

using Data;

public class IndexModel : PageModel
{
    private ShopDbContext _db;

    public IndexModel(ShopDbContext db) => _db = db;

    [BindProperty] //values will be set from input fields in page
    public Customer Login { get; set; }

    public void OnGet()
    {
        Login = new Customer();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        var customer = _db.Customers.Find(Login.Id);
        if(customer?.Password == Login.Password)
        {
            var identity = new ClaimsIdentity("Cookies");
            identity.AddClaim(new Claim(ClaimTypes.Name, Login.Id));
            await HttpContext.SignInAsync(new ClaimsPrincipal(identity));
            return RedirectToPage("Detail");
        }
        ModelState.AddModelError("", "Authentication Failed");
        return Page();
    }

}

