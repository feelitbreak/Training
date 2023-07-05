var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Middleware 1
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Hello from 1st middleware\n");

    await next();

    await context.Response.WriteAsync("Hello again from 1st middleware\n");
});

// Middleware 2
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Hello from 2nd middleware\n");

    await next();

    await context.Response.WriteAsync("Hello again from 2nd middleware\n");
});

// Middleware 3
app.Run(async (context) =>
{
    await context.Response.WriteAsync("Hello from 3rd middleware\n");
});

app.Run();
