using Microsoft.EntityFrameworkCore;
using RecruitingToolsAPI.Data;
using RecruitingToolsAPI.Repositories;
using RecruitingToolsAPI.Repositories.Interfaces;
using RecruitingToolsAPI.Services;
using RecruitingToolsAPI.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("RecruitingToolsConnection");

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Database dependencies
builder.Services.AddDbContext<RecruitingToolsDbContext>(x => x.UseSqlServer(connectionString));

//Dependences injection for Services and Repositories
builder.Services.AddScoped<ISelectionProcessService, SelectionProcessService>();
builder.Services.AddScoped<ISelectionProcessRepository, SelectionProcessRepository>();


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
