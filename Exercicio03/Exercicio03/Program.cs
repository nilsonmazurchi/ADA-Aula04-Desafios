using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101); // Gera um número aleatório entre 1 e 100
        int tentativas = 0;
        int palpite = 0;

        Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
        Console.WriteLine("Tente adivinhar o número secreto entre 1 e 100.");

        while (palpite != numeroSecreto)
        {
            Console.Write("Digite seu palpite: ");
            palpite = Convert.ToInt32(Console.ReadLine());
            tentativas++;

            if (palpite < numeroSecreto)
            {
                Console.WriteLine("O número secreto é maior. Tente novamente.");
            }
            else if (palpite > numeroSecreto)
            {
                Console.WriteLine("O número secreto é menor. Tente novamente.");
            }
        }

        Console.WriteLine($"Parabéns! Você adivinhou o número secreto {numeroSecreto} em {tentativas} tentativas.");
    }
}
