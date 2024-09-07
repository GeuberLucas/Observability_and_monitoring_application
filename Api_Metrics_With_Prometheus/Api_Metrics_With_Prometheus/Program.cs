using Api_Metrics_With_Prometheus;
using Api_Metrics_With_Prometheus.Dominio;
using Api_Metrics_With_Prometheus.Services;
using Microsoft.EntityFrameworkCore;
using OpenTelemetry.Metrics;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://*:80");
builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

builder.Services.AddControllers();

//Add file for dependecy injection
builder.Services.AddInjections();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddOpenTelemetry().ConfigureResource(resource => resource.AddService("register people")).WithMetrics(bd =>
{
    bd.AddMeter("Microsoft.AspNetCore.Routing", "Microsoft.AspNetCore.Hosting", "Microsoft.AspNetCore.Server.Kestrel");
    bd.AddPrometheusExporter();
});


var app = builder.Build();
DatabaseService.InitializeDatabase(app);
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapPrometheusScrapingEndpoint();

app.Run();
