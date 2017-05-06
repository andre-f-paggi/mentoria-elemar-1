using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MentoriaElemar1.ObjetosDeValor
{
    public class Cpf
    {
        private const int QUANTIDADE_CARACTERES_CPF = 11;
        public string CpfSemPontuacao { get; private set; }
        public string CpfComPontuacao => AplicarPontuacaoDeCpf(CpfSemPontuacao);
        public static bool ValidarCpf(string cpf)
        {
            var cpfSemPontuacao = SomenteNumeros(cpf);

            if (cpfSemPontuacao.Length != QUANTIDADE_CARACTERES_CPF)
                return false;

            var listaDeCpfsInvalidosComuns = new string[] {
            "00000000000",
            "11111111111",
            "22222222222",
            "33333333333",
            "44444444444",
            "55555555555",
            "66666666666",
            "77777777777",
            "88888888888",
            "99999999999",
        };

            // TODO: Adicionar validação de CPF de verdade

            if (listaDeCpfsInvalidosComuns.Contains(cpfSemPontuacao))
                return false;

            return true;
        }

        public Cpf(string cpf)
        {
            var cpfSemPontuacao = SomenteNumeros(cpf);

            if (cpfSemPontuacao.Length != QUANTIDADE_CARACTERES_CPF)
                throw new ArgumentException($"O CPF deve conter {QUANTIDADE_CARACTERES_CPF} caracteres");

            if (!ValidarCpf(cpf))
                throw new ArgumentException("CPF inválido");

            CpfSemPontuacao = CpfSemPontuacao;
        }

        private static string AplicarPontuacaoDeCpf(string cpfSemPontuacao)
        {
            return $"{cpfSemPontuacao.Substring(0, 2)}.{cpfSemPontuacao.Substring(3, 5)}.{cpfSemPontuacao.Substring(6, 8)}.-{cpfSemPontuacao.Substring(9, 10)}";
        }

        private static string SomenteNumeros(string texto)
        {
            var regexCaracteresNaoNumericos = new Regex("/D/g");
            var textoSomenteNumeros = regexCaracteresNaoNumericos.Replace(texto, "");
            return textoSomenteNumeros;
        }
    }
}