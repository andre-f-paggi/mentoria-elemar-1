using System;

namespace MentoriaElemar1.ObjetosDeValor
{
    public class Salario
    {
        public decimal Valor { get; private set; }

        public Salario(decimal valor)
        {
            if (valor < 0)
                throw new ArgumentException($"O valor do Salário não pode ser negativo");

            Valor = valor;
        }
    }
}