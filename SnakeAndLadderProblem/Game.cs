using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class Game
    {
        public int position = 0;
        public int player1;
        //UC1- Game played with single player at start position 0
        public void GameStart()
        {
            Console.WriteLine("Single player at start position is : " + position);
        }
    }
}
