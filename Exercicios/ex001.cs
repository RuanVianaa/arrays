using System;
using MinhaBiblioteca;
//Escreva um programa que leia ou gere um vetor de N elementos inteiros (N deve ser informado pelo
//usuário) e passe o mesmo como parâmetro para uma função que retorne a soma de seus elementos.

class ex001
{
    static void Main()
    {
        int n;
        Console.WriteLine("Entre com o tamanho do vetor:");
        n = int.Parse(Console.ReadLine());
        int[] meuVetor = new int[n];
        Biblioteca.lerVetor(meuVetor);
        Biblioteca.mostrarVetor(meuVetor);
        int soma = Biblioteca.somarVetor(meuVetor);
        Console.WriteLine($"\nSoma dos elementos do vetor: {soma}");

    }
}
