using System;
using MinhaBiblioteca;

//Escreve um programa que sorteio, aleatoriamente, N números e armazene estes em um vetor. Em seguida, o
//usuário digita um número e seu programa em C deve acusar se o número digitado está no vetor ou não. Se
//estiver, diga a posição que está.

class ex006
{

    static void Main()
    {
        int n, num, pos;
        Console.WriteLine("Quantos números deseja sortear? ");
        n = Convert.ToInt32(Console.ReadLine());
        int[] vetor = new int[n];
        Biblioteca.sortearVetor(vetor);
        Console.WriteLine("Entre com um número para ver se ele está no vetor: ");
        num = Convert.ToInt32(Console.ReadLine());
        pos = Biblioteca.procurarNumero(vetor, num);
        if (pos == -1)
        {
            Console.WriteLine("Número não encontrado.");
        }
        else
        {
            Console.WriteLine($"Número encontrado na posição {pos}.");
        }
    }
}