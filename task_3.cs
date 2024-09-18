using System;
using System.Collections.Generic;

class task_3
{
    static void Main()
    {
        Random r = new Random();
        List<int> clt1 = new List<int>();
        List<int> clt2 = new List<int>();
        List<int> clt3 = new List<int>();

        // Формування двох перших колекцій з N випадкових чисел з інтервалом [1; 10]
        for (int i = 0; i < 10; i++)
        {
            clt1.Add(r.Next(1, 11));
            clt2.Add(r.Next(1, 11));
        }

        // Виведення перших двох колекцій
        Console.WriteLine("Перша колекцiя: " + string.Join(", ", clt1));
        Console.WriteLine("Друга колекцiя: " + string.Join(", ", clt2));

        // Створення третьої колекції, згідно умовам завдання
        for (int i = 0; i < 10; i++)  // Перебирання усіх індексів обох колекцій
        {
            clt3.Add(Math.Max(clt1[i], clt2[i]));  // Визначаємо максимальне значення кожного індексу обох колекцій
                                                   // за допомогою Math.Max та додаємо до третьої колекції
        }

        // Виводимо третю колекцію
        Console.WriteLine("Третя колекцiя (з найбiльшими елементами): " + string.Join(", ", clt3));
    }
}
