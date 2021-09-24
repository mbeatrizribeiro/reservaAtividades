using ReservaAtividades.Domain.Entidades;
using ReservaAtividades.Domain.Repositorios;

namespace ReservaAtividades.Data.Repositorios
{
    public class ReservasRepository : RepositoryBase, IReservasRepository
    {
        public ReservasRepository(ReservasContext context)
            : base(context)
        {
        }

        public void SalvarReserva(Reservas idReserva)
        {
            Context.Reservas.Add(idReserva);
        }
    }
}
