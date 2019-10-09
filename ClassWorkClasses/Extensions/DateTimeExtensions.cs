using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkClasses.Extensions
{
    public static class DateTimeExtensions
    {
        public static int GetYearsDiff(this DateTime date, DateTime another)
        {
            int difference = (another.Year - date.Year - 1) +
                (((another.Month > date.Month) ||
                ((another.Month == date.Month) && (another.Day >= date.Day)))
                ? 1 : 0);
            return difference;
        }
    }
}
