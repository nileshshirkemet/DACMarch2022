using Tourism;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<ISiteStore, XmlSiteStore>();
var app = builder.Build();
app.MapDefaultControllerRoute();//controller=Home;action=Index
app.Run();
