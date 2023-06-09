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
        public const int NO_PLAY = 0;
        public const int LADDER = 1;
        public const int SNAKE = 2;
        static Random random = new Random();
        public int diceValue = random.Next(1, 7);

        //UC1- Game played with single player at start position 0
        public void GameStart()
        {
            Console.WriteLine("Single player at start position is : " + position);
        }

        //UC2- Player rolls the dice to get a number between 1 to 6.
        public void PlayerRollsDice()
        {
            Console.WriteLine("Player1 roll dice then get number: " + diceValue);
        }

        //UC3- Player then checks for a Option. They are No Play, Ladder or Snake.
        public void CheckOptions()
        {
            Random random1 = new Random();
            int option = random1.Next(0, 3);
            switch (option)
            {
                case NO_PLAY:
                    position = 0;
                    Console.WriteLine("When No Play then player stay in position:  " + position);
                    break;
                case LADDER:
                    position = position + diceValue;
                    Console.WriteLine("When get Ladder then player position:  " + position);
                    break;
                case SNAKE:
                    position = position - diceValue;
                    Console.WriteLine("When get Snake then player position:   " + position);
                    break;
            }
        }
    }
}
