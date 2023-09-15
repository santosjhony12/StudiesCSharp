using System;

namespace _02Metodos;
    class Program{
        static void Main(string[] args){
           Aluno a =new Aluno();
           a.Nota1 = 5;
           a.Nota2 = 10;
           a.Nome = "João";

           a.mensagem();
        }
}
