using System;

class Pessoa
{
    public string nome;
    public int idade;

    public void mensagem(){
        Console.WriteLine("Exibindo meu "+nome+" e idade: "+idade);
    }
}