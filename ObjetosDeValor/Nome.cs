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

        public Nome(string primeiroNome, string sobrenome)
        {
            PrimeiroNome = primeiroNome.Trim();
            Sobrenome = sobrenome.Trim();
        }
    }
}