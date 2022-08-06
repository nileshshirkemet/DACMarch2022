var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddAuthentication("Cookies")
    .AddCookie(options => options.LoginPath = "/Index");
builder.Services.AddDbContext<ClassicWebApp.Data.ShopDbContext>(options => options.UseSqlServer("Data Source=(localdb)\\SqlXE;Initial Catalog=Shop"));
var app = builder.Build();
app.UseAuthentication();
app.UseAuthorization();
app.MapRazorPages();
app.Run();
