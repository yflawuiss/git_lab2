using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Ініціалізуємо список чисел
        List<int> chisla = new List<int> { 9, 8, 2, 5, 7, 4 };

        // Виведення списку чисел
        Console.WriteLine("Список чисел:");
        for (int i = 0; i < chisla.Count; i++)
        {
            Console.Write(chisla[i] + " ");
        }

        int mx = chisla[0]; int nmx = 0;         
        for (int i = 1; i < chisla.Count; i++) 
        {
            if (chisla[i] > mx) { mx = chisla[i]; nmx = i; }
        }
        Console.WriteLine("\nМаксимальне значення: {0}, Iндекс: {1}", mx, nmx);
    }
}
