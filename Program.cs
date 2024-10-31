using Microsoft.EntityFrameworkCore;
using minimalApi.Dtos;
using minimalApi.Infrastrutura.Db;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DbContexto>(options => {
  options.UseSqlServer(
    builder.Configuration.GetConnectionString("sqlServer")
  );
});

var app = builder.Build();
app.MapGet("/", () => "Hello World eitaaa!");

app.MapPost("/login", (LoginDTO loginDTO) => {

    if(loginDTO.Email == "adm@teste.com" && loginDTO.Senha == "123456" )
      return Results.Ok("Login com sucesso");
    else
      return Results.Unauthorized();
});



app.Run();




