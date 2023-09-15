using System;

class Aluno
{
    private string nome;
    private int nota1, nota2;

    // GET E SET
    public string Nome
    {
        get{return nome;}
        set{nome = value;}
    }

    public int Nota1
    {
        get{return nota1;}
        set{nota1 = value;}
    }

    public int Nota2
    {
        get{return nota2;}
        set{nota2 = value;}
    }
    public void mensagem()
    {
        Console.WriteLine("A média de " + nome + " é " + ((nota1 + nota2)/2.0));
    }
}
