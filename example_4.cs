Random o = new Random();
List<int> chisla = new List<int>();
for (int i = 0; i < 10; i++)
{
    chisla.Add(o.Next(1, 20));
    Console.Write("{0} ", chisla[i]);
}
Console.WriteLine();
int x = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < chisla.Count; i--)
    if (chisla[i] == x) chisla.Remove(x);

for (int i = 0; i < chisla.Count; i++)
    Console.Write("{0} ", chisla[i]);
