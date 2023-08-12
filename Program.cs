using PlayerElder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerElder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(10,"Lionel Messi");
            Player player2 = new Player(7,"cristano Ronaldo",38);
            Player[] players = 
             {
                player1,
                player2,
                new Player(4,"sergio Ramos",35),
                new Player(16,"Pedri",22),

            };
            foreach (Player playerr in players) //players array name
            {
                Console.WriteLine(playerr.ShowPlayerDetails());
                
            }

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Player with Maximum Age" + Player.AgeElderPlayer(players));
            Console.WriteLine("-----------------------------------------------------------");
            Player elderPlayer1 = Player.WhoIsElderPlayer(players);
            Console.WriteLine("Details of elder Player" + elderPlayer1.ShowPlayerDetails());

            Console.WriteLine("-----------------------------------------------------------");

            Player youngPlayer1 =Player.AgeMiniumPlayer(players);
            Console.WriteLine("Details of Younger player is "+youngPlayer1.ShowPlayerDetails());
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Global Players Registered : "+TotalCounterPlayer.GlobalCounter1);

        }
    }
}
