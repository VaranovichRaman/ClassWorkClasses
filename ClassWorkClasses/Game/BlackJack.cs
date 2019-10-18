using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkClasses.Game
{
    class BlackJack
    {
        public static void BlackJackStart()
        {
            Console.WriteLine($"Hi, it's BlackJack game! Let's start game for a real man!");
            bool flag3 = true;
            while (flag3)
            {
                List<int> cards = new List<int>();
                int[] valueOfCards = { 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9, 9, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 11, 11, 11, 11 };
                Random randomForCards = new Random();
                int n = 51;
                bool flag = true;
                bool flag2 = true;
                int playersCard;
                int casinosCard;
                int scoreOfPlayer = 0;
                int scoreOfCasino = 0;
                for (int i = 0; i < valueOfCards.Length; i++)
                {
                    cards.Add(valueOfCards[randomForCards.Next(0, n)]);
                }
                playersCard = cards[n];
                cards.Remove(n);
                scoreOfPlayer += playersCard;
                n--;
                while (flag)
                {
                    Console.WriteLine($"\nYour score is {scoreOfPlayer}. Do you want another card?(type \"y\" if yes, \"n\" if no)");
                    string answer = Console.ReadLine();
                    if (answer == "y")
                    {
                        playersCard = cards[n];
                        Console.WriteLine($"\nThe value of the new card is {cards[n]}");
                        cards.Remove(n);
                        if (scoreOfPlayer + playersCard > 21 && playersCard == 11)
                        {
                            playersCard = 1;
                            scoreOfPlayer += playersCard;
                            n--;
                        }
                        else
                        {
                            scoreOfPlayer += playersCard;
                            n--;
                        }
                        if (scoreOfPlayer > 21)
                        {
                            Console.WriteLine($"\nToo many points! You lose!");
                            flag = false;
                            flag2 = false;
                            scoreOfCasino = 100;
                        }
                    }
                    else if (answer == "n")
                    {
                        Console.WriteLine($"\nYour score is {scoreOfPlayer}");
                        flag = false;
                    }
                    else
                    {
                        Console.WriteLine($"\nWrong key!");
                    }

                }
                while (flag2)
                {
                    if (scoreOfCasino < 17)
                    {
                        casinosCard = cards[n];
                        cards.Remove(n);
                        if (scoreOfCasino + casinosCard > 21 && casinosCard == 11)
                        {
                            casinosCard = 1;
                            scoreOfCasino += casinosCard;
                            n--;
                        }
                        else
                        {
                            scoreOfCasino += casinosCard;
                            n--;
                        }
                    }
                    else if (scoreOfCasino > 21)
                    {
                        Console.WriteLine($"\nCasino has too many points!");
                        flag = false;
                        flag2 = false;
                        scoreOfPlayer = 100;
                        scoreOfCasino = 21;
                    }
                    else if (scoreOfCasino >= 17 && scoreOfCasino < 21)
                    {
                        Console.WriteLine($"\nCasinos score is {scoreOfCasino}");
                        flag2 = false;
                    }
                }
                if (scoreOfCasino > scoreOfPlayer)
                {
                    Console.WriteLine($"\nCasino wins!");
                }
                else if (scoreOfCasino < scoreOfPlayer)
                {
                    Console.WriteLine($"\nYou win!");

                }
                else if (scoreOfPlayer == scoreOfCasino)
                {
                    Console.WriteLine($"\nDraw!");
                }
                bool flag4 = true;
                while (flag4)
                {
                    Console.WriteLine($"\nDo you wanna play again?(type \"y\" if yes, \"n\" if no)");
                    string answer2 = Console.ReadLine();
                    if (answer2 == "y")
                    {
                        Console.WriteLine($"\nOk, let's try again!\n");
                        flag4 = false;
                    }
                    else if (answer2 == "n")
                    {
                        Console.WriteLine($"\nThanks for a game, good bye!");
                        flag3 = false;
                        flag4 = false;
                    }
                    else
                    {
                        Console.WriteLine($"\nI don't understand you human!");
                    }
                }
            }
        }
        
           
    }
}
