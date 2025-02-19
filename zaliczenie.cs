// Program obliczający sumę liczb od 1 do n
using System;

class Program
{
    
    static int ObliczSume(int n)
    {
        int suma = 0;
        for (int i = 1; i <= n; i++)
        {
            suma += i;
        }
        return suma;
    }

    static void Main()
    {
        Console.Write("Podaj liczbę: ");
        int liczba;
        while (!int.TryParse(Console.ReadLine(), out liczba) || liczba < 1)
        {
            Console.Write("Błędne dane. Podaj liczbę większą od zera: ");
        }

        int wynik = ObliczSume(liczba);
        Console.WriteLine($"Suma liczb od 1 do {liczba} wynosi: {wynik}");
    }
}

