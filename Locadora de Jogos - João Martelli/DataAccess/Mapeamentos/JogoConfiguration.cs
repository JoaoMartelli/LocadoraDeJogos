using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio;

namespace DataAccess;

public class JogoConfiguration : IEntityTypeConfiguration<Jogo>
{
    public void Configure(EntityTypeBuilder<Jogo> builder)
    {
        builder.ToTable("Jogos").HasKey(nameof(Jogo.Id));
        builder.Property(nameof(Jogo.Id)).HasColumnName("JogoID");
        builder.Property(nameof(Jogo.Nome)).HasColumnName("Nome").HasMaxLength(60).IsRequired();
        builder.Property(nameof(Jogo.Genero)).HasColumnName("Genero").HasMaxLength(30).IsRequired();
        builder.Property(nameof(Jogo.Plataforma)).HasColumnName("Plataforma").HasMaxLength(30).IsRequired();
        builder.Property(nameof(Jogo.Disponibilidade)).HasColumnName("Disponibilidade");
    }
}