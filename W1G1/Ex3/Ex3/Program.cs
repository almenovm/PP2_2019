﻿using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            // s = "2 3 6"
            string s = Console.ReadLine();
            string[] arr = s.Split();
            // arr[0] = 2
            // arr[1] = 3
            // arr[2] = 6
            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);
            int c = int.Parse(arr[2]);
            Console.WriteLine(a + b + c);
        }
    }
}
