using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerBoards playerboard = new PlayerBoards();
            playerboard.GetPlayer1Board();
            Console.ReadLine();
        }
    }
}
