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




        public void FinalReportOf2Players()
        { //local variable
            int rollDice, playerPosition = 0, playerPosition1 = 0, playerPosition2 = 0;
            int count = 0;

            //To generate random number
            Random random = new Random();
            //List to check options
            var list = new List<string> { "No Play", "Ladder", "Snake" };
            // 1 ->player 1 is playing . 2 ->Player 2 is playing
            int playerChange = 1;
            while (playerPosition1 <= 100 || playerPosition2 <= 100)
            {
                //Print the current Player
                Console.WriteLine("Player: " + playerChange + " is playing \n");

                //Rolling dice
                rollDice = random.Next(1, 6);
                Console.WriteLine("Dice number is : " + rollDice + "\n");

                //Print user options
                Console.WriteLine("Player checks options 1.No Play  2.Ladder   3.Snake \n");

                //Use random to check user option
                int index = random.Next(list.Count);
                Console.WriteLine("Player option is : " + list[index] + "\n");


                //Goes to this loop if Player 1 is rolling dice
                if (playerChange == 1)
                {
                    //If option is "No Change" it will change player to 2
                    if (list[index] == "No Play" && playerChange == 1)
                    {
                        playerChange = 2;
                        continue;
                    }

                    //If player option is "Snake" , position will go down and will change player to 2
                    if (list[index] == "Snake")
                    {
                        playerPosition1 -= rollDice;
                        playerChange = 2;
                    }

                    //If after rolling rice player position <100 then it will increment the position of player to that of number of dice
                    if (playerPosition1 + rollDice < 100 && playerChange == 1)
                    {
                        if (list[index] == "Ladder") playerPosition1 += rollDice;
                    }

                    //If after rolling dice player reached "Exactly 100" then it will increment and come out of loop.Winner is Player 1
                    if (list[index] == "Ladder" && (playerPosition1 + rollDice == 100) && playerChange == 1)
                    {
                        playerPosition1 += rollDice;
                        break;
                    }

                    //If after getting "Snake" option , position is less than 0, then reset position to 0
                    if (playerPosition1 < 0 && list[index] == "Snake")
                    {
                        playerPosition1 = 0;
                    }

                    //Print to Console
                    Console.WriteLine("Player 1 current position : " + playerPosition1);
                }

                //Goes to this loop if Player 2 is rolling dice
                else if (playerChange == 2)
                {
                    //If option is "No Change" it will change player to 1
                    if (list[index] == "No Play" && playerChange == 2)
                    {
                        playerChange = 1;
                        continue;
                    }

                    //If after rolling rice player position <100 then it will increment the position of player to that of number of dice
                    if (playerPosition2 + rollDice < 100 && playerChange == 2)
                    {
                        if (list[index] == "Ladder") playerPosition2 += rollDice;
                    }

                    //If player option is "Snake" , position will go down and will change player to 1
                    if (list[index] == "Snake")
                    {
                        playerPosition2 -= rollDice;
                        playerChange = 1;
                    }

                    //If after rolling dice player reached "Exactly 100" then it will increment and come out of loop.Winner is Player 2
                    if (list[index] == "Ladder" && (playerPosition2 + rollDice == 100) && playerChange == 2)
                    {
                        playerPosition2 += rollDice;
                        break;
                    }

                    //If after getting "Snake" option , position is less than 0, then reset position to 0
                    if (playerPosition2 < 0 && list[index] == "Snake")
                    {
                        playerPosition2 = 0;
                    }

                    //Print to Console
                    Console.WriteLine("Player 2 current position : " + playerPosition2);
                    count++;
                }
            }
            //Print winner of 2Player Game
            if (playerPosition1 == 100)
            {
                Console.WriteLine("Winner is player 1  :" + playerPosition1);
                Console.WriteLine("Final position of player 2  :" + playerPosition2);
            }
            else
            {
                Console.WriteLine("Winner is player 2  :" + playerPosition2);
                Console.WriteLine("Final position of player 1  :" + playerPosition1);
            }
            //Total Number of game played
            Console.WriteLine("Number of times game played :" + count);
        }
    }
}
