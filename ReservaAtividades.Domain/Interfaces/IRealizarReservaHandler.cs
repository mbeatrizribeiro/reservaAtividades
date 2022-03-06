using ReservaAtividades.Domain.Requests;
using ReservaAtividades.Domain.Views;
using System.Threading;
using System.Threading.Tasks;

namespace ReservaAtividades.Domain.Interfaces
{
    public interface IRealizarReservaHandler
    {
        Task<ReservaViewModel> Handle(RealizarReservaRequest request, CancellationToken cancellation);
    }
}
