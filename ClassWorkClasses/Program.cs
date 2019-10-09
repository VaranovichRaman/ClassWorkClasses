using ClassWorkClasses.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var kris = new Tolchok();
            kris.DateOfBirth = new DateTime(1994, 6, 7);
            Console.WriteLine($"age is {kris.Age}");
            Console.ReadLine();
        }
    }
}
