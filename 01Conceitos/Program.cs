using System;

namespace _01Conceitos;
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Hello World");

            Pessoa pesssoa = new Pessoa();
            pesssoa.nome = "Jhony";
            pesssoa.idade = 18;
            pesssoa.mensagem();
        }
}
