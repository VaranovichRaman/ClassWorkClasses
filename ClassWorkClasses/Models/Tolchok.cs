using ClassWorkClasses.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiscellaniousFiles;

namespace ClassWorkClasses.Models
{
    public class Tolchok
    {
        public string Name { get; set; }
        public int Age { get { return DateOfBirth.GetYearsDiff(DateTime.Now); } }
        public Weapons FavoriteWeapon { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ClubNames Club { get; set; }
        public string PrepareReport()
        {
            return $"Tolchok {Name} is {Age} years old is in {Club.ToString()}";
        }

    }
}
