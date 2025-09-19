using System;
using MinhaBiblioteca;

//Leia um vetor de caracteres. Utilize a função Length para obter a quantidade de elementos do vetor de
//caracteres. Escreva o vetor lido em ordem inversa.

class ex009
{
    static void Main()
    {
        int n;
        Console.WriteLine("Entre com o tamanho do vetor:");
        n = int.Parse(Console.ReadLine());
        char[] vetor = new char[n];
        Console.WriteLine("Entre com os caracteres do vetor:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Vetor[{i}]: ");
            vetor[i] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine("Vetor em ordem inversa:");
        for (int i = vetor.Length - 1; i >= 0; i--)
        {
            Console.Write(vetor[i] + " ");
        }
    }
}