using System;
class Program
{
    static string decodificador(string fraseCodificada)
    {
        int n = fraseCodificada.Length;
        int pos = 0;
        char[] decodificada = new char[n];
        for (int i = 0; i < n; i++)
        {
            if (fraseCodificada[i] != 'p')
            {
                decodificada[pos] = fraseCodificada[i];
                pos++;
            }
            else
            {
                i++;
                decodificada[pos] = fraseCodificada[i];
                pos++;
            }
        }
        return new string(decodificada);
    }
    static void Main()
    {
        string frase;
        Console.WriteLine("Entre com uma frase codificada:");
        frase = Console.ReadLine();
        Console.WriteLine("Frase decodificada:" + decodificador(frase));

    }
}
