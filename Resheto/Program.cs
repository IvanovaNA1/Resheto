﻿using System.Diagnostics;

Stopwatch stopwatch = new Stopwatch();
while (true)
{
    Console.WriteLine();
    Console.WriteLine("Решето Эратосфена");
    Console.WriteLine("ВВедите число");
    int x = Convert.ToInt32(Console.ReadLine());
    bool[] A = new bool[x];

    stopwatch.Start();
    for (int i = 2; i < Math.Sqrt(x) + 1; i++)
    {
        if (!A[i])
        {
            for (int j = i * i; j < x; j += i)
            {
                A[j] = true;
            }
        }
    }
    for (int i = 2; i < x; i++)
    {
        if (!A[i])
        {
            Console.WriteLine("{0}", i);
        }
    }
    stopwatch.Stop();
    Console.WriteLine("Время:" + stopwatch.ElapsedMilliseconds);
}