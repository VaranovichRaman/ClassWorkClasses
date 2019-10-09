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
            kris.Club = ClubNames.Izmereniya;
            Console.WriteLine($"age is {kris.Age}");
            if (kris.Club == ClubNames.Brigada)
            {
                Console.WriteLine("100% Dexter enrolled!");
            }
            else if (kris.Club == ClubNames.DSE)
            {
                Console.WriteLine("Ex Vice Minister is your head");
            }
            else 
            { 
                Console.WriteLine("noname club"); 
            }
            Console.WriteLine(kris.PrepareReport());
            //var newDate = new DateTime(1945, 5, 9);
            //Console.WriteLine($"{newDate.GetYearsDiff(DateTime.Now)} years from victory of {newDate.GetCentury()} century greatest war"); 
            Console.ReadLine();
        }
    }
}
