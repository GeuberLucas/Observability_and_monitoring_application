using Api_Metrics_With_Prometheus;
using Api_Metrics_With_Prometheus.Dominio;
using Api_Metrics_With_Prometheus.Services;
using Microsoft.EntityFrameworkCore;
using OpenTelemetry.Metrics;
using OpenTelemetry.Trace;
var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://*:80");

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddControllers();

//Add file for dependecy injection
builder.Services.AddInjections();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddOpenTelemetry().WithMetrics(bd =>
{
    bd.AddMeter("Microsoft.AspNetCore.Routing");
    bd.AddMeter("Microsoft.AspNetCore.Hosting");
    bd.AddMeter("Microsoft.AspNetCore.Diagnostics");
    bd.AddMeter("Microsoft.AspNetCore.Http.Connections");
    bd.AddMeter("Microsoft.AspNetCore.Server.Kestrel");
    bd.AddAspNetCoreInstrumentation();
    bd.AddPrometheusExporter();


}).WithTracing(tracing =>
{
    tracing.AddAspNetCoreInstrumentation();
    tracing.AddHttpClientInstrumentation();
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
