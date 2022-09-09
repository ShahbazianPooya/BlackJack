using BlackJack_Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            game.AddPlayer("Ali", 1000);
            game.AddPlayer("Hassan", 1000);
            game.Start();

        }
    }
}
