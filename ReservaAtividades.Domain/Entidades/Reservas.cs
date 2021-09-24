using System;

namespace ReservaAtividades.Domain.Entidades
{
    public class Reservas
    {
        public int IdPasseio { get; set; }
        public double ValorPasseio { get; set; }
        public DateTime DataPasseio { get; set; }
        public DateTime HoraPasseio { get; set; }
        public string Descricao { get; set; }
        public int QuantidadePessoas { get; set; }
    }
}
