using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Ladder
{
    internal class GamePlay
    {
        int rollDice, playerPosition = 0, playerPosition1 = 0, playerPosition2 = 0;
        int count = 0;
        public void Start()
        {
            Console.WriteLine("Game is Start:" + playerPosition);
        }

        public void RollDice()
        {
            int playerPos = 0, rollDice;
            Random random = new Random();
            rollDice = random.Next(1, 7);
            Console.WriteLine("Rolled Dice number is:" + rollDice);
        }


        public void CheckingPlayerPosition()
        {
            int playerPosition = 0, rollDice;
            
            Random random = new Random();
            rollDice = random.Next(1, 6);
            Console.WriteLine("Rolled Dice number is:" + rollDice);
            
            Console.WriteLine("Player Option 1.No Play 2.Ladder 3.Snake");
            var list = new List<string> { "No Play", "Ladder", "Snake" };
           
            int pos = random.Next(list.Count);
            
            if (list[pos] == "Ladder")
            {
                playerPosition += rollDice;

            }
            else if (list[pos] == "Snake")
            {
                playerPosition -= rollDice;

            }
            
            Console.WriteLine("Player option:" + list[pos]);
            Console.WriteLine("player updated position:" + playerPosition);
        }


        public void PlayerPositionZeroRestart()
        {
            //local variable
            int rollDice, playerPosition = 0;

            //To generate random number
            Random random = new Random();
            //List to check options
            var list = new List<string> { "No Play", "Ladder", "Snake" };

            //Conditions for user options
            rollDice = random.Next(1, 6);
            Console.WriteLine("Dice number is : " + rollDice);

            //Print user options
            Console.WriteLine("Player checks options 1.No Play  2.Ladder   3.Snake");

            //Use random to check user option
            int index = random.Next(list.Count);
            Console.WriteLine("Player option is : " + list[index]);
            if (playerPosition + rollDice < 100)
            {
                if (list[index] == "Ladder") playerPosition += rollDice;
                if (list[index] == "Snake") playerPosition -= rollDice;
            }

            if (playerPosition < 0)
            {
                playerPosition = 0;
            }
            //Print to Console
            Console.WriteLine("Player current position : " + playerPosition);
            Console.WriteLine("Final position is :" + playerPosition);
        }


        public void PlayerPositionExact100()
        {
            //local variable
            int rollDice, playerPosition = 0;
            int count = 0;

            //To generate random number
            Random random = new Random();
            //List to check options
            var list = new List<string> { "No Play", "Ladder", "Snake" };

            //Conditions for user options
            rollDice = random.Next(1, 6);
            Console.WriteLine("Dice number is : " + rollDice);

            //Print user options
            Console.WriteLine("Player checks options 1.No Play  2.Ladder   3.Snake");

            //Use random to check user option
            int position = random.Next(list.Count);
            Console.WriteLine("Player option is : " + list[position]);
            if (playerPosition + rollDice < 100)
            {
                if (list[position] == "Ladder")
                {
                    playerPosition += rollDice;
                }
                if (list[position] == "Snake")
                {
                    playerPosition -= rollDice;
                }
            }
            else if (playerPosition + rollDice == 100 && list[position] == "Ladder")
            {
                playerPosition += rollDice;

            }

            if (playerPosition < 0)
            {
                playerPosition = 0;
            }
            //Print to Console
            Console.WriteLine("Player current position : " + playerPosition);
            count++;
            Console.WriteLine("Final position is :" + playerPosition);
            Console.WriteLine("Total Moves:" + count);
        }



        public void PositionOfDiceEveryTimePlayed()
        {
            //local variable
            int rollDice, playerPosition = 0;
            int count = 0;

            //To generate random number
            Random random = new Random();
            //List to check options
            var list = new List<string> { "No Play", "Ladder", "Snake" };

            //Conditions for user options
            rollDice = random.Next(1, 6);
            Console.WriteLine("Dice number is : " + rollDice);

            //Print user options
            Console.WriteLine("Player checks options 1.No Play  2.Ladder   3.Snake");

            //Use random to check user option
            int position = random.Next(list.Count);
            Console.WriteLine("Player option is : " + list[position]);
            if (playerPosition + rollDice < 100)
            {
                if (list[position] == "Ladder")
                {
                    playerPosition += rollDice;
                }
                if (list[position] == "Snake")
                {
                    playerPosition -= rollDice;
                }
            }
            else if (playerPosition + rollDice == 100)
            {
                playerPosition += rollDice;

            }

            if (playerPosition < 0)
            {
                playerPosition = 0;
            }
            //Print to Console
            Console.WriteLine("Player current position : " + playerPosition);
            count++;
            Console.WriteLine("Final position is :" + playerPosition);
            Console.WriteLine("number of times:" + count);
        }
    }
}
