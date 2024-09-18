using System;
using System.Collections.Generic;
using System.Linq;

class task_2
{
    static void Main()
    {
        Random r = new Random();
        List<int> num = new List<int>();

        // Формування колекції з N випадкових чисел з інтервалом [5; 51]
        for (int i = 0; i < 50; i++)
        {
            num.Add(r.Next(1, 51));
        }
        // Виведення отриманої колекції
        Console.WriteLine("Початкова колекцiя:\n" + string.Join(", ", num));

        // Цикл з пошуку першого числа із колекції, який кратний своєй останній цифрі
        for (int i = 0; i < num.Count; i++)
        {
            int last_num = num[i] % 10; // Ділення з остачею на 10 для кожного числа

            // Якщо остання цифра не 0 і число кратне своїй останній цифрі
            if (last_num != 0 && num[i] % last_num == 0)
            {
                // Додавання -1 перед необхідним числом
                num.Insert(i, -1);
                break; // Зупинка пошуків після першого знайденого необхідного числа
            }
        }

        // Виведення результатів
        Console.WriteLine();
        Console.WriteLine("Пiсля вставки '-1':\n" + string.Join(", ", num));
    }
}