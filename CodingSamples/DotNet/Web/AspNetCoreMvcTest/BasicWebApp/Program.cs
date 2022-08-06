using BasicWebApp.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); //enabling MVC
builder.Services.AddSingleton<IHitCounter, PageCounter>();
var app = builder.Build();
//map all paths of form /X/Y/z to XController::Y(z)
app.MapControllerRoute("default", "{controller=Greeter}/{action=Greet}/{id=Visitor}");
app.Run();
