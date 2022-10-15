using System.Diagnostics;

Stopwatch stopwatch = new Stopwatch();
while (true)
{
    Console.WriteLine();
    Console.WriteLine("Решето Эратосфена");
    Console.WriteLine("Вdедите число");
    int x = Convert.ToInt32(Console.ReadLine());
    bool[] M = new bool[x];

    stopwatch.Start();
    for (int i = 2; i < Math.Sqrt(x) + 1; i++)
    {
        if (!M[i])
        {
            for (int j = i * i; j < x; j += i)
            {
                M[j] = true;
            }
        }
    }
    for (int i = 2; i < x; i++)
    {
        if (!M[i])
        {
            Console.WriteLine("{0}", i);
        }
    }
    stopwatch.Stop();
    Console.WriteLine("Время:" + stopwatch.ElapsedMilliseconds);
}
