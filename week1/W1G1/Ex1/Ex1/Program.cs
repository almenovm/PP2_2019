﻿using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string s1, s2;
            s1 = Console.ReadLine();
            s2 = Console.ReadLine();
            int a = int.Parse(s1);
            int b = int.Parse(s2);
            Console.WriteLine(a + b);
        }
    }
}
