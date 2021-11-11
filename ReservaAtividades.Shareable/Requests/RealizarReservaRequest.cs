using ReservaAtividades.Shareable.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaAtividades.Shareable.Requests
{
    public record RealizarReservaRequest(long cpf, ReservaDto reserva)
    {

    }
}
