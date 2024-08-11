using OpenTelemetry.Metrics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddOpenTelemetry().WithMetrics(builder => {
    builder.AddMeter("Microsoft.AspNetCore.Routing");
    builder.AddMeter("Microsoft.AspNetCore.Hosting");
    builder.AddMeter("Microsoft.AspNetCore.Diagnostics");
    builder.AddMeter("Microsoft.AspNetCore.Http.Connections");
    builder.AddAspNetCoreInstrumentation();
    builder.AddPrometheusExporter();


});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapPrometheusScrapingEndpoint();

app.Run();
