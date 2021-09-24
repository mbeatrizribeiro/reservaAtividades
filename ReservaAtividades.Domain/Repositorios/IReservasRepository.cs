using ReservaAtividades.Domain.Entidades;

namespace ReservaAtividades.Domain.Repositorios
{
    public interface IReservasRepository : IRepository
    {
        public void SalvarReserva(Reservas idReserva);
    }
}
