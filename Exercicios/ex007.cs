using System;
using MinhaBiblioteca;

//Escreva um programa que leia ou gere dois vetores de N posições e faça a multiplicação dos elementos de
//mesmo índice, colocando o resultado em um terceiro vetor. Mostre o vetor resultante.

class ex007
{
    static void Main()
    {
        int n;
        Console.WriteLine("Entre com o tamanho dos vetores:");
        n = int.Parse(Console.ReadLine());

        int[] vetor1 = new int[n];
        int[] vetor2 = new int[n];
        int[] vetorResultado = new int[n];

        Biblioteca.gerarVetor(vetor1);
        Biblioteca.gerarVetor(vetor2);

        for (int i = 0; i < n; i++)
        {
            vetorResultado[i] = vetor1[i] * vetor2[i];
        }

        Console.WriteLine("Vetor 1:");
        Biblioteca.mostrarVetor(vetor1);
        Console.WriteLine("\nVetor 2:");
        Biblioteca.mostrarVetor(vetor2);
        Console.WriteLine("\nVetor Resultado:");
        Biblioteca.mostrarVetor(vetorResultado);
    }
}
