using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO ROCK PAPER SCISSORS!!!!");
            Console.WriteLine("Press any key to start!!");
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Enter your name: ");
            string player_1 = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"{player_1}'s Friend, Enter you name: ");
            string player_2 = Console.ReadLine();

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"{player_1} Make a choice: (R)ock, (P)aper, or (S)cissors: ");
                string p1_input = Console.ReadLine().ToUpper();
                Console.Clear();
                Console.WriteLine($"{player_2} Make a choice: (R)ock, (P)aper, or (S)cissors: ");
                string p2_input = Console.ReadLine().ToUpper();
                Console.Clear();

                if (p1_input == "R" && p2_input == "R")
                    Console.WriteLine($"[{player_1} :  Rock] [{player_2} : Rock] Tie!!");
                
                else if (p1_input == "P" && p2_input == "P")
                    Console.WriteLine($"[{player_1} :  Paper] [{player_2} : Paper] Tie!!");
                
                else if (p1_input == "S" && p2_input == "S")
                    Console.WriteLine($"[{player_1} :  Scissors] [{player_2} : Scissors] Tie!!");
                
                else if (p1_input == "R" && p2_input == "P")
                    Console.WriteLine($"[{player_1} :  Rock] [{player_2} : Paper] {player_2} Wins!!");
                
                else if (p1_input == "R" && p2_input == "S")
                    Console.WriteLine($"[{player_1} : Rock] [{player_2} : Scissors] {player_1} Wins!!");
                
                else if (p1_input == "P" && p2_input == "R")
                    Console.WriteLine($"[{player_1} : Paper] [{player_2} : Rock] {player_1} Wins!!");
                
                else if (p1_input == "P" && p2_input == "S")
                    Console.WriteLine($"[{player_1} : Paper] [{player_2} : Scissors] {player_2} Wins!!");
                
                else if (p1_input == "S" && p2_input == "R")
                    Console.WriteLine($"[{player_1} : Scissors] [{player_2} : Rock] {player_2} Wins!!");
                
                else if (p1_input == "S" && p2_input == "P")
                    Console.WriteLine($"[{player_1} : Scissors] [{player_2} : Paper] {player_1} Wins!!");
                
                else
                    Console.WriteLine($"Invalid Inputs Detected.");
                
                Console.WriteLine("<Press any key to play again>");
                Console.ReadKey();
            }
        }
    }

}
