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
            var player = new Tolchok();
            Console.WriteLine($"Greatings in TolchUniverse! What's your name?");
            player.Name = Console.ReadLine();
            Console.WriteLine($"Hi {player.Name}, when are you born?(date format: yyyy.mm.dd):");
            player.DateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"\nChoose your favorite weapon {player.Name}:");
            player.FavoriteWeapon = new Weapon();
            Console.WriteLine($"\nWeapons type:");
            foreach (WeaponType type in (WeaponType[])Enum.GetValues(typeof(WeaponType)))
            {
                Console.WriteLine($"{(int)type} - {type}");
            }
            player.FavoriteWeapon.TypeOfWeapon = (WeaponType)int.Parse(Console.ReadLine());
            Console.WriteLine($"\nWeapons size:");
            foreach (WeaponSize size in (WeaponSize[])Enum.GetValues(typeof(WeaponSize)))
            {
                Console.WriteLine($"{(int)size} - {size}");
            }
            player.FavoriteWeapon.SizeOfWeapon = (WeaponSize)int.Parse(Console.ReadLine());
            Console.WriteLine($"\nWeapons material:");
            foreach (WeaponMaterial material in (WeaponMaterial[])Enum.GetValues(typeof(WeaponMaterial)))
            {
                Console.WriteLine($"{(int)material} - {material}");
            }            
            player.FavoriteWeapon.MaterialOfWeapon = (WeaponMaterial)int.Parse(Console.ReadLine());
            Console.WriteLine($"\nChoose your club:");
            player.ClubInfo = new Clubs();
            foreach (ClubNames clubName in (ClubNames[])Enum.GetValues(typeof(ClubNames)))
            {
                Console.WriteLine($"{(int)clubName} - {clubName}");
            }
            player.ClubInfo.ClubName = (ClubNames)int.Parse(Console.ReadLine());
            Console.WriteLine($"{player.Name}'s favorite weapon is {player.FavoriteWeapon.SizeOfWeapon} {player.FavoriteWeapon.MaterialOfWeapon} {player.FavoriteWeapon.TypeOfWeapon}");
            if (player.ClubInfo.ClubName == ClubNames.OldCamp)
            {
                player.ClubInfo.HeadOfClubName = "Gomes";                
            }
            else if (player.ClubInfo.ClubName == ClubNames.NewCamp)
            {
                player.ClubInfo.HeadOfClubName = "Li";
            }
            else
            {
                player.ClubInfo.HeadOfClubName = "Berion";
            }
            player.ClubInfo.MembersOfClub.Add(player.Name);
            
            //var newDate = new DateTime(1945, 5, 9);
            //Console.WriteLine($"{newDate.GetYearsDiff(DateTime.Now)} years from victory of {newDate.GetCentury()} century greatest war"); 
            Console.ReadLine();
        }
    }
}
