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

        private int Years(DateTime start, DateTime end)
        {
            int difference = (end.Year - start.Year - 1) +
                (((end.Month > start.Month) ||
                ((end.Month == start.Month) && (end.Day >= start.Day)))
                ? 1 : 0);
            return difference;
        }
    }
}
