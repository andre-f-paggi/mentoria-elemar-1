using System;

namespace MentoriaElemar1.ObjetosDeValor
{
    public class Nome
    {
        public string PrimeiroNome { get; private set; }
        public string Sobrenome { get; private set; }
        public string NomeCompleto => $"{PrimeiroNome} {Sobrenome}";

        public string ToString()
        {
            return NomeCompleto;
        }

        public Nome(string primeiroNome, string sobrenome = null)
        {
            if (primeiroNome.Length < 2)
                throw new ArgumentException("Preencha o primeiro nome");

            PrimeiroNome = primeiroNome.Trim();
            Sobrenome = sobrenome?.Trim() ?? "";
        }
    }
}