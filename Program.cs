using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApploop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            string choice;
            do
            {
                Console.WriteLine("enter number to find out table of the number");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine($"table of {num} as follows");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{num} * {i} = \t {(num * i)}");
                }
                Console.WriteLine("do you wanna learn more \n if yess press y \n to exit press any other key");
                choice = Console.ReadLine().ToLower();
            }
            while (choice == "y");
            }


    }
    }


