
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaAtividades.Shareable.Requests
{
    public sealed class RealizarReservaRequestValidation : AbstractValidator<RealizarReservaRequest>
    {
        public RealizarReservaRequestValidation()
        {
            RuleFor(x => x.cpf).GreaterThan(0).WithMessage("Numero do cpf é obrigatório");
            RuleFor(x => x.reserva).NotNull().WithMessage("Reserva é obrigatório");
        }
    }
}
