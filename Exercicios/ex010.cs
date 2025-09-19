using System;
using MinhaBiblioteca;

//Tentando descobrir se um dado era viciado, um dono de cassino honesto o lançou N vezes. Dados os n
//resultados dos lançamentos que devem ser armazenados em um vetor, determinar o número de ocorrências
//de cada face.

class ex010
{
    static void Main()
    {
        int n;
        Console.WriteLine("Quantas vezes o dado foi lançado?");
        n = int.Parse(Console.ReadLine());
        int[] resultados = new int[n];
        Console.WriteLine("Entre com os resultados dos lançamentos (valores entre 1 e 6):");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Lançamento {i + 1}: ");
            resultados[i] = int.Parse(Console.ReadLine());
            while (resultados[i] < 1 || resultados[i] > 6)
            {
                Console.WriteLine("Valor inválido. Por favor, entre com um valor entre 1 e 6.");
                Console.Write($"Lançamento {i + 1}: ");
                resultados[i] = int.Parse(Console.ReadLine());
            }
        }

        int[] contagemFaces = new int[6];

        for (int i = 0; i < n; i++)
        {
            contagemFaces[resultados[i] - 1]++;
        }

        Console.WriteLine("Contagem de ocorrências de cada face:");
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine($"Face {i + 1}: {contagemFaces[i]} ocorrência(s)");
        }
    }
}