using OnionArcExample.Infrastructure;
using OnionArcExample.Persistence;

var builder = WebApplication.CreateBuilder(args);
//var someService = builder.Services.GetService<IConfiguration>();
IConfiguration configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddPersistenceServices(configuration);
builder.Services.AddInfrastructureServices();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
