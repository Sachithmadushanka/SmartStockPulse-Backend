using DotNetEnv;
using SmartStockPulse.Application.Services;
using SmartStockPulse.Infrastructure.Repositories;

// Load environment variables from .env file (in solution root)
Env.Load();

var builder = WebApplication.CreateBuilder(args);

// ------------------------
// Add services to the container
// ------------------------

// Controllers
builder.Services.AddControllers();

// Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp", policy =>
    {
        policy.WithOrigins("http://localhost:5173")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});



// ------------------------
// Dependency Injection
// ------------------------

// Register Repository
builder.Services.AddSingleton<IStockRepository, StockRepository>();

// Register Service
builder.Services.AddSingleton<IStockService, StockService>();

// ------------------------
var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowReactApp");

app.UseAuthorization();

app.MapControllers();

app.Run();
