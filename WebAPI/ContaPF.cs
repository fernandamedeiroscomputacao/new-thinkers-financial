using System;

namespace Financial.WebAPI
{
    public class ContaPF
    {
        public int Agencia { get; set; }
        public int Conta { get; set; }

        public string TipoConta { get; set; }
        public string NomeCompleto { get; set; }
    }
}
