﻿using PMath;
using PMath.Statistics;

class Program
{
    public static void Main()
    {
        QSet32 set = new("test", 56, 2, 3, 4, 5, 6, 7);
        Console.WriteLine(set.StdDev());
    }
}