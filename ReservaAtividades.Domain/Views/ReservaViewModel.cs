using ReservaAtividades.Domain.Entidades;
using System.Collections.Generic;

namespace ReservaAtividades.Domain.Views
{
    public record ReservaViewModel (
        bool Success,
        int NumeroReserva,
        Reservas Reservas
    );
}
