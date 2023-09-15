using System;
class Funcionario : Pessoa
    {
        public double Salario { get; set; }

        public Funcionario(string nome, string email, int idade, double salario)
            : base(nome, email, idade)
        {
            Salario = salario;
        }
    }
