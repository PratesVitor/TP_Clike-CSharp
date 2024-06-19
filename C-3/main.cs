using System;

class Program
{
    static void Main()
    {
        // Declaração de variáveis
        int N, P, M, pequeno = 0, medio = 0, T;

        // Solicita e lê o número de premiados com validação
        do
        {
            Console.WriteLine("Digite o número de premiados (deve ser maior ou igual a 1):");
            N = int.Parse(Console.ReadLine());
            if (N < 1)
            {
                Console.WriteLine("Número inválido. Por favor, digite um número maior ou igual a 1.");
            }
        } while (N < 1);

        // Solicita e lê os tamanhos solicitados
        for (int i = 0; i < N; i++)
        {
            do
            {
                Console.WriteLine("Digite o tamanho solicitado pelo premiado " + (i + 1) + " (1 para pequeno, 2 para médio):");
                T = int.Parse(Console.ReadLine());
                if (T != 1 && T != 2)
                {
                    Console.WriteLine("Tamanho inválido. Digite 1 para pequeno ou 2 para médio.");
                }
            } while (T != 1 && T != 2); // Repete até que o usuário digite 1 ou 2

            if (T == 1)
            {
                pequeno++; // Conta o número de camisetas pequenas solicitadas
            }
            else
            {
                medio++; // Conta o número de camisetas médias solicitadas
            }
        }

        // Solicita e lê o número de camisetas pequenas produzidas
        Console.WriteLine("Digite o número de camisetas pequenas produzidas:");
        P = int.Parse(Console.ReadLine());

        // Solicita e lê o número de camisetas médias produzidas
        Console.WriteLine("Digite o número de camisetas médias produzidas:");
        M = int.Parse(Console.ReadLine());

        // Verifica se a quantidade produzida atende a demanda
        if (pequeno <= P && medio <= M)
        {
            Console.WriteLine("\nS"); // Todos os premiados serão atendidos
        }
        else
        {
            Console.WriteLine("\nN"); // Nem todos os premiados serão atendidos
        }
    }
}
