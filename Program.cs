using GerenciadorDeDoacoes.Application.Interfaces;
using GerenciadorDeDoacoes.Application.Services;
using GerenciadorDeDoacoes.Domain.Interfaces;
using GerenciadorDeDoacoes.Infrastructure.Connections;
using GerenciadorDeDoacoes.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Mapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Database configuration
builder.Services.AddDbContext<GerenciadorDeDoacoesContext>(option =>
{
    // Desenvolvimento
    option.UseInMemoryDatabase("GerenciadorDeDoacoes");
});

// Repositories 
builder.Services.AddScoped<ICadastroOngRepository, CadastroOngRepository>();

// Services
builder.Services.AddScoped<ICadastroOngService, CadastroOngService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
