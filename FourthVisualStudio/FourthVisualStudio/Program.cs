using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdVisualStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            int game = 0;
            String player1;
            String player2;
            player1 = "0";
            player2 = "0";
            do
            {
                Console.WriteLine("Input the score for player1");
                player1 = Console.ReadLine();
                Console.WriteLine("Input the score for player2");
                player2 = Console.ReadLine();
                game = score(player1, player2);
            } while (game == 0);

            Console.ReadLine();
        }

        private static int score(string player1, string player2)
        {
            if (player1 == "0" && player2 == "0")
                Console.WriteLine("Love-All");
            else if (player1 == "15" && player2 == "0")
                Console.WriteLine("Fifteen-Love");
            else if (player1 == "30" && player2 == "0")
                Console.WriteLine("Thirty-Love");
            else if (player1 == "30" && player2 == "15")
                Console.WriteLine("Thirty-Fifteen");
            else if (player1 == "30" && player2 == "30")
                Console.WriteLine("Thirty-All");
            else if (player1 == "30" && player2 == "15")
                Console.WriteLine("Thirty-Fifteen");
            else if (player1 == "40" && player2 == "40")
                Console.WriteLine("Deuce");
            else if (player1 == "Adv" && player2 == "40")
                Console.WriteLine("Adventage for player 1");
            else if (player1 == "win" && (player2 == "0" || player2 == "15" || player2 == "30" || player2 == "40"))
            {
                Console.WriteLine("Win for player 1");
                return 1;
            }
            return 0;
        }
    }
}
