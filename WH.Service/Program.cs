using System.Configuration;
using WH.Shared.Entities;

var builder = WebApplication.CreateBuilder(args);

var configBuilder = new ConfigurationBuilder()
      .AddJsonFile($"appsettings.json", true, true);

var config = configBuilder.Build();

// Add services to the container.
Settings settings = new Settings(config["DataSourceType"], config["CsvDataPath"], config["CsvDataComboPath"]);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

app.Run();
