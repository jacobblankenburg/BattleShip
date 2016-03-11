using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public class MainPage
    {
        private PlayBattleship playbattleship = new PlayBattleship();
        PlayerBoards playerBoards = new PlayerBoards();

        public void UserControls()
        {
            Console.WriteLine("WELCOME TO BATTLE SHIP\n ");
            Console.WriteLine("Please enter your selection\n");
            Console.WriteLine("Player 1 board, Player 2 board, Play, End");

            string userPick = Console.ReadLine();
            bool Running = true;

            while (Running)
            {
                switch (userPick.ToLower())
                {
                    case "player 1 board":
                        playerBoards.GetPlayer1Board();
                        break;

                    case "player 2 board":
                        playerBoards.GetPlayer2Board();
                        break;

                    case "play":
                        playbattleship.UserPlaysGame();
                        break;

                    case "end":
                        Running = false;
                        break;

                    default:
                        Console.WriteLine("Please enter valid user selection");
                        break;

                }
                break;
            }

        }
    }
}
