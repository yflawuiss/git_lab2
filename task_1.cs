using System;
using System.Collections.Generic;
using System.Linq;

class task_1
{
    static void Main()
    {
        Random r = new Random();
        List<int> num = new List<int>();

        // Формування колекції з N випадкових чисел з інтервалом [1; 90]
        for (int i = 0; i < 90; i++)
        {
            num.Add(r.Next(1, 91));
        }
        // Виведення отриманої колекції
        Console.WriteLine("Початкова колекцiя: " + string.Join(", ", num));

        // Видалення чисел, які кратні 3 і закінчуються на 5
        num.RemoveAll(x => x % 3 == 0 && x % 10 == 5);

        // Виведення остаточної колекції
        Console.WriteLine();
        Console.WriteLine("Пiсля видалення: " + string.Join(", ", num));
    }
}
