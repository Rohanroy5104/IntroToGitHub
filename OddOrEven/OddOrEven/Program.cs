﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number : ");
            num = Convert.ToInt32(Console.ReadLine());
            if(num%2==0)
            
                Console.WriteLine("Entered number is a even number : ");

                else

                    Console.WriteLine("Entered number is a odd number : ");
                Console.ReadLine();
            
        }
    }
}
