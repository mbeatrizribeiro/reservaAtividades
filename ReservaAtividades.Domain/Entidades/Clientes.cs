using System;

namespace ReservaAtividades.Domain.Entidades
{
    public class Clientes
    {
        public int Cpf { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime Nascimento { get; set; }
        public string EnderecoLogradouro { get; set; }
        public int EnderecoNumero{ get; set; }
        public string EnderecoComplemento { get; set; }
        public long Celular { get; set; }
        public long ContatoEmergencia { get; set; }
    }
}
