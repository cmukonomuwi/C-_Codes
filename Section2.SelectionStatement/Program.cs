﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2.SelectionStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 6;
            int y = 7;
            int z = 10;
            int r = 11;
            if (x < y)
            {
                Console.WriteLine("Y greater than X");
            }

            if (x > y) //Remember that the first true condition will be executed and then it will exit the if
            {
                Console.WriteLine("X greater than Y");
            }
            else if (z > y)
            {
                Console.WriteLine("Z greater than Y");
            }
            else if (r > z)
            {
                Console.WriteLine("r greater than z");
            }
            else
            {
                Console.WriteLine("Y greater than X");
            }

            switch (r)
            {
                case 4:
                    Console.WriteLine("R equals 4");
                    break;
                case 5:
                    Console.WriteLine("R equals 5");
                    break;
                case 11:
                    Console.WriteLine("R equals 11");
                    break;
            }
            Console.ReadLine();
        }
    }
}
