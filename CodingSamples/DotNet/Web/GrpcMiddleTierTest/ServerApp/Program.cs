var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGrpc(); //enable gRPC
var app = builder.Build();
app.MapGrpcService<ServerApp.Shopping.OrderManagerService>();
app.Run("http://localhost:4000"); //gRPC requires Kestrel with HTTP/2 (see appsettings.json)
