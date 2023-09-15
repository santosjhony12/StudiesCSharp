using System;

class Aluno
{
    private string nome;
    private int nota1, nota2;

    public double media()
    {
        return (nota1 + nota2) / 2.0; // Usar 2.0 para a média decimal
    }

    public void mensagem()
    {
        Console.WriteLine("Informe o nome do aluno: ");
        nome = Console.ReadLine();

        Console.WriteLine("Informe a primeira nota: ");
        nota1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a segunda nota: ");
        nota2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("A média de " + nome + " é " + media());
    }
}
