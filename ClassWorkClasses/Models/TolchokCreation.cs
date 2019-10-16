using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkClasses.Models
{
    public class TolchokCreation
    {
        public static void Start(bool flag, Clubs tolchOldCampClub, Clubs tolchNewCampClub, Clubs tolchSwampCampClub)
        {
            bool flag2 = true;
            while (flag)
            {
                Tolchok player = new Tolchok();
                player.TolchoksGames = new List<Games>();
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
                while (flag2)
                {
                    Console.WriteLine($"What game did you play? ");
                    Games game = new Games();
                    
                    game.GameName = Console.ReadLine();
                    Console.WriteLine($"Who was the master of the game?");
                    game.MasterOfGame = Console.ReadLine();
                    Console.WriteLine($"What was the size of the contribution?");
                    game.Contribution = int.Parse(Console.ReadLine());
                    player.TolchoksGames.Add(game);
                    Console.WriteLine($"Have you played other games?(type \"n\" if not)");
                    string otherGamesAnswer = Console.ReadLine();
                    if (otherGamesAnswer == "n")
                    {
                        flag2 = false;
                    }
                }
                flag2 = true; 
                Console.WriteLine($"{player.Name}'s favorite weapon is {player.FavoriteWeapon.SizeOfWeapon} {player.FavoriteWeapon.MaterialOfWeapon} {player.FavoriteWeapon.TypeOfWeapon}");
                if (player.ClubInfo.ClubName == ClubNames.OldCamp)
                {
                    player.ClubInfo.HeadOfClubName = "Gomes";
                    tolchOldCampClub.MembersOfClub.Add(player);
                }
                else if (player.ClubInfo.ClubName == ClubNames.NewCamp)
                {
                    player.ClubInfo.HeadOfClubName = "Li";
                    tolchNewCampClub.MembersOfClub.Add(player);
                }
                else
                {
                    player.ClubInfo.HeadOfClubName = "Berion";
                    tolchSwampCampClub.MembersOfClub.Add(player);
                }
                Console.WriteLine($"Wanna add another tolch?(type \"n\" if you won't)");
                string anotherTolchAdd = Console.ReadLine();
                if (anotherTolchAdd == "n")
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine($"I think it was \"yes\".");
                }
            }
        }
    }
}
