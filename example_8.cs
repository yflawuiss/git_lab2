Random o = new Random();
List<int> chisla = new List<int>();
for (int i = 0; i < 10; i++)
{
    chisla.Add(o.Next(1, 20));
    Console.Write("{0} ", chisla[i]);
}
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
for (int i = chisla.Count - 1; i >= 0; i--)
    if (chisla[i] % 2 == 0) chisla.Insert(i, x);
for (int i = 0; i < chisla.Count; i++)
    Console.Write("{0} ", chisla[i]);