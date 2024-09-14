using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio;

namespace DataAccess;

public class AluguelConfiguration : IEntityTypeConfiguration<Aluguel>
{
    public void Configure(EntityTypeBuilder<Aluguel> builder)
    {
        builder.ToTable("Alugueis").HasKey(nameof(Aluguel.Id));
        builder.Property(nameof(Aluguel.Id)).HasColumnName("AluguelID").IsRequired();
        builder.Property(nameof(Aluguel.DataAluguel)).HasColumnName("DataAluguel").IsRequired();
        builder.Property(nameof(Aluguel.DataDevolucao)).HasColumnName("DataDevolucao");
        builder.Property(nameof(Aluguel.ClienteId)).HasColumnName("ClienteID").IsRequired();
        builder.Property(nameof(Aluguel.JogoId)).HasColumnName("JogoID").IsRequired();

        builder.HasOne(aluguel => aluguel.Cliente)
                .WithMany(cliente => cliente.Alugueis)
                .HasForeignKey(aluguel => aluguel.ClienteId);

        builder.HasOne(aluguel => aluguel.Jogo)
                .WithMany(jogo => jogo.Alugueis)
                .HasForeignKey(aluguel => aluguel.JogoId);
    }
}