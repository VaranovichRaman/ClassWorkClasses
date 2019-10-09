using ClassWorkClasses.Extensions;
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
            kris.Name = "Kris";
            kris.DateOfBirth = new DateTime(1994, 6, 7);
            Console.WriteLine($"age is {kris.Age}");
            Console.WriteLine(kris);
            var newDate = new DateTime(1945, 5, 9);
            Console.WriteLine($"{newDate.GetYearsDiff(DateTime.Now)} years from victory of {newDate.GetCentury()} century greatest war"); 
            Console.ReadLine();
        }
    }
}
