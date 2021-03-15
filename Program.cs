using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player0 = new CreativeSmackTalkingPlayer();
            player0.Name = "Smack Talk Jimmy";

            Player player4 = new SoreLoserPlayer();
            player4.Name = "Karen";

            Player player5 = new SoreLoserPlayer();
            player4.Name = "Karen";
           
            
            Player player1 = new SmackTalkingPlayer();
            player1.Name = "Bob";

            Player player2 = new OneHigherPlayer();
            player2.Name = "Sue";
 
        

            Player player3 = new HumanPlayer();
            player3.Name = "Wilma";

            
            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

           

            List<Player> players = new List<Player>() {
               player5, player4, player0, player1, player2, player3, large
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play noe another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
               try{
                player1.Play(player2);
               }
               catch (Exception)
               {
                Console.WriteLine("Welp, looks like Karen is being Karen again...");
               }
               
            }
        }
    }
}