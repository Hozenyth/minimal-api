using Microsoft.EntityFrameworkCore;
using minimalApi.Dominio.Entidades;

namespace minimalApi.Infrastrutura.Db;

public class DbContexto : DbContext
{
    private readonly IConfiguration _configuracaoAppSettings;
    public DbContexto(IConfiguration configuration)
    {
        _configuracaoAppSettings = configuration;
    }
    public DbSet<Administrador> Administradores {get; set;} = default!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
        var stringConexao = _configuracaoAppSettings.GetConnectionString("sqlServer")?.ToString();
        if(!string.IsNullOrEmpty(stringConexao))
        {
              optionsBuilder.UseSqlServer(stringConexao);
        }
        }      
    }

}