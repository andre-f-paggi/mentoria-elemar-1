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
            => Novo(nome, cpf, salario);

        public static Empregado Novo(Nome nome, Cpf cpf, Salario salario){
            var empregado = new Empregado
            {
                Id = Guid.NewGuid(),
                Nome = nome,
                Cpf = cpf,
                Salario = salario
            };
            return empregado;
        }
    }
}
