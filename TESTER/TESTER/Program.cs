using Microsoft.AspNetCore.Builder;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

var builder = WebApplication.CreateBuilder(args);
//var conection = builder.Configuration.GetConnectionString("CadenaSQL");
//var connectionString = Environment.GetEnvironmentVariable("conexion");
// Add services to the container.

builder.Services.AddControllers();



//using (SqlConnection connection = new SqlConnection(connectionString))
//{
//    connection.Open(); 
//}


//EVITAR CICLOS EN LOS MODELOS Y DATOS

    //.AddJsonOptions(opt =>
    // {
    //     opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    // });

    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//reglas de desbloqueo de cors para poder usar el API en el Fronted
var misReglas = "ReglasCors";
builder.Services.AddCors(opt =>
{
    opt.AddPolicy(name: misReglas, builder =>
    {
        builder
        .AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();

    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //utilizo las reglas cors
    app.UseCors(misReglas);
    //app.Configuration.GetConnectionString("conexion");
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
