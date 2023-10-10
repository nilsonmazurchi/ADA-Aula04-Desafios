using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o valor inicial do intervalo:");
        int inicio = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor final do intervalo:");
        int fim = Convert.ToInt32(Console.ReadLine());

        // Encontrar o menor e o maior valor entre inicio e fim
        int menorValor = Math.Min(inicio, fim);
        int maiorValor = Math.Max(inicio, fim);

        int somaPares = 0;

        for (int i = menorValor; i <= maiorValor; i++)
        {
            if (i % 2 == 0) // Verifica se o número é par
            {
                somaPares += i; // Adiciona o número par à soma
            }
        }

        Console.WriteLine($"A soma dos números pares no intervalo de {menorValor} a {maiorValor} é: {somaPares}");
    }
}

