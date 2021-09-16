﻿using System;

namespace Lab1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Run(args);
        }


        public static void Run(string[] args)
        {
            if (args.Length > 0)
            {
                InputedArgs input = new InputedArgs(args);

                Console.WriteLine($"Sum of integer digits in command line arguments {input.Sum()}, production of digits {input.Multi()}.");
            }
            else
            {
                Console.WriteLine("There is no command line arguments!");
            }
            Console.ReadKey();
        }
    }
}
