using MediatR;
using ReservaAtividades.Data.Dtos;
using ReservaAtividades.Domain.Entidades;
using ReservaAtividades.Domain.Interfaces;
using ReservaAtividades.Domain.Requests;
using ReservaAtividades.Domain.Views;
using System.Threading;
using System.Threading.Tasks;

namespace ReservaAtividades.Domain.Handlers
{
    public class RealizarReservaHandler : IRealizarReservaHandler, IRequestHandler<RealizarReservaRequest, ReservaViewModel>
    {
        private readonly ReservaDto reservas;
        public RealizarReservaHandler(){
        }

        public async Task<ReservaViewModel> Handle(RealizarReservaRequest request, CancellationToken cancellation)
        {
            int numeroReserva = 0;
            Reservas atividade = new Reservas()
            {
                IdPasseio = request.IdPasseio
            };

            if(request.QuantidadeCompra <= reservas.QuantidadeVagas)
            {
                for (int i = 0; i <= request.QuantidadeCompra; i++)
                {
                   numeroReserva = reservas.IdReserva = i;
                }
            }

            return new ReservaViewModel(true, numeroReserva, atividade);
        }
    }
}
