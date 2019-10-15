using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkClasses.Models
{
    public class Clubs
    {
        public ClubNames ClubName { get; set; }
        public string HeadOfClubName { get; set; }
        public List<string> MembersOfClub { get; set; }
    }
}
