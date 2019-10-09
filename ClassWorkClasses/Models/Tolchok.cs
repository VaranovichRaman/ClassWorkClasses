using ClassWorkClasses.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkClasses.Models
{
    public class Tolchok
    {
        public string Name { get; set; }
        public int Age { get { return DateOfBirth.GetYearsDiff(DateTime.Now); } }
        public DateTime DateOfBirth { get; set; }

        public override string ToString()
        {
            return $"Tolchok {Name} is {Age} years old";
        }

    }
}
