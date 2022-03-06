using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.CodeAnalysis;

namespace ReservaAtividades.Data.EntityTypeConfiguration
{
    //[ExcludeFromCodeCoverage]
    //public class ClientesConfiguration : IEntityTypeConfiguration<Clientes>
    //{
    //    public void Configure(EntityTypeBuilder<Clientes> builder)
    //    {
    //        builder
    //           .ToTable("TB_CLIENTES");

    //        builder
    //            .Property(x => x.Cpf)
    //            .HasColumnName("PK_CPF_CLIENTE")
    //            .IsRequired();

    //        builder
    //            .Property(x => x.Nome)
    //            .HasColumnName("NM_CLIENTE")
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .IsRequired();

    //        builder
    //            .Property(x => x.Idade)
    //            .HasColumnName("IDADE_CLIENTE")
    //            .HasMaxLength(10)
    //            .IsUnicode(false)
    //            .IsRequired();

    //        builder
    //            .Property(x => x.Nascimento)
    //            .HasColumnName("NS_CLIENTE")
    //            .HasMaxLength(500)
    //            .IsUnicode(false)
    //            .IsRequired();

    //        builder
    //           .Property(x => x.EnderecoLogradouro)
    //           .HasColumnName("LOGRADOURO_CLIENTE")
    //           .HasMaxLength(500)
    //           .IsUnicode(false)
    //           .IsRequired();

    //        builder
    //           .Property(x => x.EnderecoNumero)
    //           .HasColumnName("ENDNUM_CLIENTE")
    //           .HasMaxLength(500)
    //           .IsUnicode(false)
    //           .IsRequired();

    //        builder
    //         .Property(x => x.EnderecoComplemento)
    //         .HasColumnName("ENDCMP_CLIENTE")
    //         .HasMaxLength(500)
    //         .IsUnicode(false)
    //         .IsRequired();

    //        builder
    //         .Property(x => x.Celular)
    //         .HasColumnName("CEL_CLIENTE")
    //         .HasMaxLength(500)
    //         .IsUnicode(false)
    //         .IsRequired();

    //        builder
    //         .Property(x => x.ContatoEmergencia)
    //         .HasColumnName("CTTEME_CLIENTE")
    //         .HasMaxLength(500)
    //         .IsUnicode(false)
    //         .IsRequired();
    //    }
    //}
}

