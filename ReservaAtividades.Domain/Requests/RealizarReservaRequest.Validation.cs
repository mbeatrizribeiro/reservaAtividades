using FluentValidation;

namespace ReservaAtividades.Domain.Requests
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
