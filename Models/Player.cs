using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerElder.Models
{
    internal class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int Age { get; set; }
        public Player() {
            Console.WriteLine("Default Constructor");
            TotalCounterPlayer.GlobalCounter1++;
        }
        public Player(int id, string name) :this()
        {
            this.Id = id;
            this.Name = name;
        }
        public Player(int id,string name,int age) :this(id,name) 
        { 
            this.Age = age;
        }
        public static string AgeElderPlayer(Player [] player)
        {
            int ageElder= player[0].Age;
            string nameplayer = "";
            int agePlayer = 0;
            for (int i = 1; i < player.Length; i++)
            {
                if (ageElder < player[i].Age)
                {
                    ageElder = player[i].Age;
                    nameplayer = player[i].Name;
                    agePlayer = player[i].Age;
                }

            }
            return $"Name : {nameplayer}\nAge : {agePlayer}";
        }


        public static Player WhoIsElderPlayer(Player []players)
        {
            int ElderPlayer =players[0].Age;
            Player playerDetails = null;
            for (int i = 1;i<players.Length;i++)
            {
                if (ElderPlayer < players[i].Age)
                {
                    ElderPlayer = players[i].Age;
                    playerDetails = players[i];
                }

            }
            return playerDetails;
        }

        public static Player AgeMiniumPlayer(Player[]players)
        {
            int youngerPlayer = players[0].Age;
            Player playerDetails = null;
            for(int i = 1;i<players.Length;i++)
            {
                if (youngerPlayer < players[i].Age)
                {
                    youngerPlayer = players[i].Age;
                    playerDetails = players[i];
                }
            }
            return playerDetails;
        }
        public string ShowPlayerDetails()
        {
            return $"id : {Id}\nName : {Name}\nAge : {Age}";
        }
    }
}
