using ReservaAtividades.Shareable.Enums;
using System;

namespace ReservaAtividades.Data.Dtos
{
    public class ReservaDto
    {
        /// <summary>
        /// ID da reserva no banco.
        /// </summary>
        public int IdReserva { get; set; }

        /// <summary>
        /// código pré-definido que indica qual o IdPasseio
        /// </summary>
        public Passeio IdPasseio { get; set; }

        public DateTime Data { get; set; }

        public int QuantidadeVagas { get; set; }

    }
}
