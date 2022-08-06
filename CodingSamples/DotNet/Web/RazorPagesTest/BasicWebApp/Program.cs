using BasicWebApp.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages(); //enable razor-pages
builder.Services.AddSingleton<IHitCounter, PageCounter>();
var app = builder.Build();
app.MapRazorPages();
app.Run();
