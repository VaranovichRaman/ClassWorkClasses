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
            bool flag = true;            
            Clubs tolchOldCampClub = new Clubs();
            tolchOldCampClub.MembersOfClub = new List<Tolchok>();
            Clubs tolchNewCampClub = new Clubs();
            tolchNewCampClub.MembersOfClub = new List<Tolchok>();
            Clubs tolchSwampCampClub = new Clubs();
            tolchSwampCampClub.MembersOfClub = new List<Tolchok>();
            
            
            
            TolchokCreation.Start(flag, tolchOldCampClub, tolchNewCampClub, tolchSwampCampClub);

            Console.WriteLine($"Old Camp members:");
            foreach (var item in tolchOldCampClub.MembersOfClub)
            {
                Console.WriteLine($"\n {item.Name} in {item.ClubInfo.ClubName}, head of club: {item.ClubInfo.HeadOfClubName}, favorite material: {item.FavoriteWeapon.MaterialOfWeapon}");
                Console.WriteLine($"His/her games:");
                foreach (var item2 in item.TolchoksGames)
                {
                    Console.WriteLine($"\n{item2.GameName}");
                }
            }
            Console.WriteLine($"New Camp members:");
            foreach (var item in tolchNewCampClub.MembersOfClub)
            {
                Console.WriteLine($"\n {item.Name} in {item.ClubInfo.ClubName}, head of club: {item.ClubInfo.HeadOfClubName}, favorite material: {item.FavoriteWeapon.MaterialOfWeapon}");
                Console.WriteLine($"His/her games:");
                foreach (var item2 in item.TolchoksGames)
                {
                    Console.WriteLine($"\n{item2.GameName}");
                }
            }
            Console.WriteLine($"Swamp Camp members:");
            foreach (var item in tolchSwampCampClub.MembersOfClub)
            {
                Console.WriteLine($"\n {item.Name} in {item.ClubInfo.ClubName}, head of club: {item.ClubInfo.HeadOfClubName}, favorite material: {item.FavoriteWeapon.MaterialOfWeapon}");
                Console.WriteLine($"His/her games:");
                foreach (var item2 in item.TolchoksGames)
                {
                    Console.WriteLine($"\n{item2.GameName}");
                }
            }





            //var newDate = new DateTime(1945, 5, 9);
            //Console.WriteLine($"{newDate.GetYearsDiff(DateTime.Now)} years from victory of {newDate.GetCentury()} century greatest war"); 
            Console.ReadLine();
        }
    }
}
