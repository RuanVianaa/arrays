//Leia um vetor DNA de caracteres para receber as letras A, T, C e G que representam as bases do DNA. Este
//vetor será responsável por representar uma fita de um gene de até 50 bases. Gere o vetor complementar ao
//vetor DNA e o apresente (Lembrando as bases complementares A=T C=G).
using System;
using MinhaBiblioteca;

class ex005
{

    static void Main()
    {
        string dna;
        Console.WriteLine("Entre com a fita de DNA: ");
        dna = Console.ReadLine();
        string comp = Biblioteca.complementarDNA(dna);
        Console.WriteLine($"Fita complementar: {comp}");
    }
}