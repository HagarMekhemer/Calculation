// Program.cs
using Calculation.DSL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<AddService>();
builder.Services.AddScoped<SubtractService>();
builder.Services.AddScoped<IMathApiClientService, MathApiClientService>();
builder.Services.AddControllers();
builder.Services.AddLogging(logging =>
{
    logging.AddConsole();
});

var app = builder.Build();
app.MapControllers();
app.Run();