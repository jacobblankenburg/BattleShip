using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public class PlayBattleship
    {
        FileReader fileread = new FileReader();
        MainPage main = new MainPage();
        public void UserPlaysGame()
        {
            Console.WriteLine("Please select your action\n");
            Console.WriteLine("Player 1, Player 2, Home, End");

            string UserSelect = Console.ReadLine();
            bool RunningGame = true;

            while (RunningGame)
            {
                switch (UserSelect.ToLower())
                {
                    case "player 1":

                        break;

                    case "player 2":

                        break;

                    case "home":
                        main.UserControls();
                        break;

                    case "end":
                        RunningGame = false;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid responce");
                        break;
                }
                break;
            }

        }

        public void PlayGame()
        {
            bool isHit = true;

            Console.WriteLine("Player 1 take your shot");

            if (isHit)
            {
                foreach (string CheckCordinets in COLLECTION)
                {
                    Console.WriteLine("Hit");
                }
                
            }
            else
            {
                Console.WriteLine("Miss");
            }
            // read players boards
            // use .contains to check if entry exsists
            //if it doesnt exist return false
            //if it does exist retun hit
            //play till all ships are sank
            //display the winner 
        }
    }
}
