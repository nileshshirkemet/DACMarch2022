using BasicWebApp.Services;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddSingleton<IHitCounter, SiteCounter>();
builder.Services.AddSingleton<IHitCounter, PageCounter>();
var app = builder.Build();
app.UseMiddleware<BasicWebApp.Middlewares.Pausing>(TimeSpan.FromSeconds(1));
app.UseStaticFiles();
app.MapGet("/Welcome", DoGreeting);
app.MapPost("/Count", DoCounting);
app.Run();

async Task DoGreeting(HttpResponse response, string guest = "Visitor")
{
    await response.WriteAsync(@$"
        <html>
            <head>
                <title>BasicWebApp</title>
            </head>
            <body>
                <h1>Welcome {guest}</h1>
                <b>Current Time: </b>{DateTime.Now}
            </body>
        </html>
    ");
}

async Task DoCounting(HttpRequest request, HttpResponse response, IHitCounter counter)
{
    string guest = request.Form["user"];
    if(guest.Length == 0)
        response.Redirect("/Welcome");
    else
    {
        await response.WriteAsync(@$"
            <html>
                <head>
                    <title>BasicWebApp</title>
                </head>
                <body>
                    <h1>Hello {guest}</h1>
                    <b>Number of Greetings: </b>{counter.CountNext(guest)}
                </body>
            </html>
        ");
    }
}
