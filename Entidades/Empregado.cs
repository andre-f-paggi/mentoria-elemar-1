using MentoriaElemar1.ObjetosDeValor;
using System;

namespace MentoriaElemar1.Entidades
{
    public class Empregado
    {
        public Guid Id { get; private set; }
        public Nome Nome { get; private set; }
        public Cpf Cpf { get; private set; }
        public Salario Salario { get; private set; }

        public Empregado AtualizarNome(Nome nome){
            Nome = nome;
            return this;
        }

        public Empregado AtualizarCpf(Cpf cpf){
            Cpf = cpf;
            return this;
        }

        public Empregado AtualizarSalario(Salario salario){
            Salario = salario;
            return this;
        }

        protected Empregado()
        {
            
        }

        public Empregado(Nome nome, Cpf cpf, Salario salario)
        {
            Id = Guid.NewGuid();
            Nome = nome ?? throw new ArgumentException("O Nome é obrigatório");
            Cpf = cpf ?? throw new ArgumentException("O CPF é obrigatório");
            Salario = salario ?? throw new ArgumentException("O Salário é obrigatório");
        }

        public static Empregado Novo(Nome nome, Cpf cpf, Salario salario){
            return new Empregado(nome, cpf, salario);
        }
    }
}
