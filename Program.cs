using Calculation.DSL;

var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddSingleton<AddService>();
builder.Services.AddSingleton<SubtractService>();

// Add controllers to the service collection
builder.Services.AddControllers(); 

var app = builder.Build();

// Map controllers to routes
app.MapControllers(); // This is fine as it maps the controllers to their routes

app.Run();


