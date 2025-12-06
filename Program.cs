var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (HttpContext ctx) =>
{
    Console.WriteLine($"Request from {ctx.Connection.RemoteIpAddress}");
    return "Hello from Cloud Run!";
});

var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
app.Urls.Add($"http://0.0.0.0:{port}");

app.Run();
