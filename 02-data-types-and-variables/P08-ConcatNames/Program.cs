﻿using System;

namespace P08_ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string delimiter = Console.ReadLine();
            Console.WriteLine($"{firstName}{delimiter}{lastName}");
        }
    }
}