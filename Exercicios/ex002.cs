using System;
using MinhaBiblioteca;
//Escreva um programa que leia ou gere um vetor de N elementos inteiros. A seguir, crie uma função que receba
//esse vetor e conte quantos valores impares existem no vetor. Retorne a quantidade de impares.
class ex002
{
    static void Main()
    {
        int n;
        Console.WriteLine("Entre com o tamanho do vetor:");
        n = int.Parse(Console.ReadLine());
        int[] meuVetor = new int[n];
        Biblioteca.gerarVetor(meuVetor);
        Biblioteca.mostrarVetor(meuVetor);
        int quantidadeImpares = Biblioteca.contarImpares(meuVetor);
        Console.WriteLine($"\nQuantidade de valores ímpares no vetor: {quantidadeImpares}");

    }
}
