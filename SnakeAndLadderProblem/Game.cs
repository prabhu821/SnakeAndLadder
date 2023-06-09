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
        static Random random = new Random();
        int diceValue = random.Next(1, 7);

        //UC1- Game played with single player at start position 0
        public void GameStart()
        {
            Console.WriteLine("Single player at start position is : " + position);
        }

        //UC2- Player rolls the dice to get a number between 1 to 6.
        public void PlayerRollsDice()
        {
            Console.WriteLine("Player 1 roll dice then get number: " + diceValue);
        }
    }
}
