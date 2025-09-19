using System;
using MinhaBiblioteca;

//Receber um vetor de N posições do tipo inteiro verificar quantas vezes um dado valor informado pelo usuário
//se encontra no vetor. Apresente também todos elementos do vetor.

class ex008
{
    static void Main()
    {
        int n, valor, contador = 0;
        Console.WriteLine("Entre com o tamanho do vetor:");
        n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];
        Biblioteca.lerVetor(vetor);
        Console.WriteLine("Entre com um valor para verificar quantas vezes ele aparece no vetor:");
        valor = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            if (vetor[i] == valor)
            {
                contador++;
            }
        }

        Console.WriteLine($"O valor {valor} aparece {contador} vezes no vetor.");
        Console.WriteLine("Elementos do vetor:");
        Biblioteca.mostrarVetor(vetor);
    }
}