using System.Data;
using Dominio;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class Contexto : DbContext
{
    public string stringConexao { get; set; } = "Server=JOÃO-PAULO\\SQLEXPRESS;Database=LocadoraJogos;TrustServerCertificate=true;Trusted_connection=True";

    public DbSet<Jogo> Jogos { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Aluguel> Alugueis { get; set; }

    private readonly DbContextOptions _options;

    public Contexto() { }
    public Contexto(DbContextOptions options) : base(options)
    {
        _options = options;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (_options == null)
            optionsBuilder.UseSqlServer(stringConexao);
    }

    public IDbConnection CriarConexao()
    {
        return new SqlConnection(stringConexao);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ClienteConfiguration());
        modelBuilder.ApplyConfiguration(new AluguelConfiguration());
        modelBuilder.ApplyConfiguration(new JogoConfiguration());
    }
}