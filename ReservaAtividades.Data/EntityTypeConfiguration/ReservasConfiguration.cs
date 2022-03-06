using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.CodeAnalysis;

namespace ReservaAtividades.Data.EntityTypeConfiguration
{
    [ExcludeFromCodeCoverage]
    public class ReservasConfiguration
    {
        //public void Configure(EntityTypeBuilder<Reservas> builder)
        //{
        //    builder
        //       .ToTable("TB_CLIENTES");

        //    builder
        //        .Property(x => x.IdPasseio)
        //        .HasColumnName("PK_ID_PASSEIO")
        //        .IsRequired();

        //    builder
        //        .Property(x => x.ValorPasseio)
        //        .HasColumnName("VALOR_PASSEIO")
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .IsRequired();

        //    builder
        //        .Property(x => x.DataPasseio)
        //        .HasColumnName("DATA_PASSEIO")
        //        .HasMaxLength(10)
        //        .IsUnicode(false)
        //        .IsRequired();

        //    builder
        //        .Property(x => x.HoraPasseio)
        //        .HasColumnName("HORA_PASSEIO")
        //        .HasMaxLength(500)
        //        .IsUnicode(false)
        //        .IsRequired();
        //}
    }
}
