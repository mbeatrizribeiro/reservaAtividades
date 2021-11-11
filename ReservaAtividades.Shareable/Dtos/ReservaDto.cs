using ReservaAtividades.Shareable.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaAtividades.Shareable.Dtos
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
        
    }
}
