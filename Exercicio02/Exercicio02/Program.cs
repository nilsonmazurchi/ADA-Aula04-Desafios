using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o número de termos da sequência de Fibonacci que você deseja gerar:");
        int n = Convert.ToInt32(Console.ReadLine());

        int primeiroTermo = 0;
        int segundoTermo = 1;

        Console.WriteLine($"Os primeiros {n} termos da sequência de Fibonacci são:");
        Console.Write($"{primeiroTermo} {segundoTermo}");

        for (int i = 2; i < n; i++)
        {
            int proximoTermo = primeiroTermo + segundoTermo;
            Console.Write($" {proximoTermo}");

            // Atualiza os termos para o próximo cálculo na sequência
            primeiroTermo = segundoTermo;
            segundoTermo = proximoTermo;
        }

        Console.WriteLine();
    }
}
