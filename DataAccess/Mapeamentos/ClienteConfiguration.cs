using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio;

namespace DataAccess;

public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("Clientes").HasKey(nameof(Cliente.Id));
        builder.Property(nameof(Cliente.Nome)).HasColumnName("Nome").IsRequired().HasMaxLength(60);
        builder.Property(nameof(Cliente.Email)).HasColumnName("Email").IsRequired().HasMaxLength(60);
        builder.Property(nameof(Cliente.Telefone)).HasColumnName("Telefone").IsRequired().HasMaxLength(11);
    }
}