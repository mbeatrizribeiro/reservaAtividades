using MediatR;
using ReservaAtividades.Domain.Views;
using System;

namespace ReservaAtividades.Domain.Requests
{
    public class RealizarReservaRequest : IRequest<ReservaViewModel>
    {
        public long Cpf { get; set; }
        public int NumeroCartao { get; set; }
        public string Logradouro { get; set; }
        public int NumeroCasa { get; set; }
        public string Complemento { get; set; }
        public int IdPasseio { get; set; }
        public DateTime DataReserva { get; set; }
        public DateTime DataCompra { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public int QuantidadeCompra { get; set; }

    }
}
