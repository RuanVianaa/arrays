using System;
using MinhaBiblioteca;
//Dado um vetor de n números reais, crie uma função que retorne o menor elemento do vetor, apresente o vetor.
class ex003
{
    static void Main()
    {
        int n;
        Console.WriteLine("Entre com o tamanho do vetor:");
        n = int.Parse(Console.ReadLine());
        int[] meuVetor = new int[n];
        Biblioteca.gerarVetor(meuVetor);
        Biblioteca.mostrarVetor(meuVetor);
        int menorElemento = Biblioteca.encontrarMenorElemento(meuVetor);
        Console.WriteLine($"\nMenor elemento do vetor: {menorElemento}");
    }
}
