var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World eitaaa!");

app.MapPost("/login", (minimalApi.Dtos.LoginDTO loginDTO) => {

    if(loginDTO.Email == "adm@teste.com" && loginDTO.Senha == "123456" )
      return Results.Ok("Login com sucesso");
    else
      return Results.Unauthorized();
});



app.Run();




