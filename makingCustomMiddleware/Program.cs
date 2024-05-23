var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Assalam o Alaikum");
    await next(context);
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("My name is hamza and I am a student of aptech gulshan II here in the month of may we learn asp.net mvc 6 which was simillar to laravel mvc\n");
    await next(context);
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Our faculty name is Sir Syed Muhammad Arsalan Shah Bukhari (SSM - ASB)\n");
    await next(context);
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("In this Institute we already C# under Sir Syed Arsalan\n");
    await next(context);
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("overall feedback is that everything is average\n");
    await next(context);
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("here this one small task is end\n");
});

app.Run();
