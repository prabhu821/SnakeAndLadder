﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem;

public class Game
{
    //insatnce variable
    public int position = 0;
    public int player1;
    public int diceRollCount = 0;
    public int diceRollCountP1 = 0;
    public int diceRollCountP2 = 0;
    public int positionplayer1 = 0;
    public int positionplayer2 = 0;

    //Constant variables
    public const int NO_PLAY = 0;
    public const int LADDER = 1;
    public const int SNAKE = 2;
    public const int WINNING_POSITION = 100;
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
        int option = random.Next(0, 3);
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

    //UC4- Repeat till the Player reaches the winning position 100.
    public void WinningPosition()
    {
        while (position != WINNING_POSITION)
        {
            int diceValue = random.Next(1, 7);
            int option = random.Next(0, 3);
            switch (option)
            {
                case NO_PLAY:
                    Console.WriteLine("When No Play then player stay in position:  " + position);
                    break;
                case LADDER:
                    position = position + diceValue;
                    Console.WriteLine("When get Ladder then player position:  " + position);
                    break;
                case SNAKE:
                    position = position - diceValue;
                    Console.WriteLine("When get Snake then player position:   " + position);
                    if (position < 0)
                    {
                        position = 0;
                    }
                    break;
            }
            Console.WriteLine("player position is :" + position);
        }
    }

    //UC5- Ensure the player gets to exact winning position 100.
    public void EnsurePlayerGetExcatWinningPosition()
    {
        while (position != WINNING_POSITION)
        {
            int diceValue = random.Next(1, 7);
            int option = random.Next(0, 3);
            switch (option)
            {
                case NO_PLAY:
                    Console.WriteLine("Dice value get: {0} and When No Play then player position:  {1} ", diceValue, position);
                    break;
                case LADDER:
                    position = position + diceValue;
                    Console.WriteLine("Dice value get: {0} and When get Ladder then player position:  {1}", diceValue, position);
                    if (position > 100)
                    {
                        position = position - diceValue;
                    }
                    break;
                case SNAKE:
                    position = position - diceValue;
                    Console.WriteLine("Dice value get: {0} and When get Snake then player position:  {1} ", diceValue, position);
                    if (position < 0)
                    {
                        position = 0;
                    }
                    break;
            }
            Console.WriteLine("player position is :" + position);
            if (position == 100)
            {
                Console.WriteLine("GAME IS OVER YOU WIN THE GAME");
                break;
            }
        }
    }

    //UC6-Report the number of times the dice was played to win the game
    public void ReportNumberOfTimesDicePlayedToWinGame()
    {
        while (position != WINNING_POSITION)
        {
            int diceValue = random.Next(1, 7);
            int option = random.Next(0, 3);
            diceRollCount++;
            switch (option)
            {
                case NO_PLAY:
                    Console.WriteLine("Dice value get: {0} and When No Play then player position:  {1} ", diceValue, position);
                    break;
                case LADDER:
                    position = position + diceValue;
                    Console.WriteLine("Dice value get: {0} and When get Ladder then player position:  {1}", diceValue, position);
                    if (position > 100)
                    {
                        position = position - diceValue;
                    }
                    break;
                case SNAKE:
                    position = position - diceValue;
                    Console.WriteLine("Dice value get: {0} and When get Snake then player position:  {1} ", diceValue, position);
                    if (position < 0)
                    {
                        position = 0;
                    }
                    break;
            }
            Console.WriteLine("player position: {0} and Dice Roll Count: {1} ", position, diceRollCount);
            if (position == 100)
            {
                Console.WriteLine("Game is over you won the game");
                break;
            }
        }
    }

    //UC7-Play the game with two Players
    public void GamePlayWithTwoPlayers()
    {
        Console.WriteLine("********************Game is start now and Game Play between Two player********************\n");
        while (positionplayer1 <= WINNING_POSITION && positionplayer2 <= WINNING_POSITION)
        {
            int diceValue1 = random.Next(1, 7);
            Console.WriteLine("PLAYER1 -----> ");
            int option1 = random.Next(0, 3);
            diceRollCountP1++;
            switch (option1)
            {
                case NO_PLAY:
                    Console.WriteLine("Dice value get: {0} and When No Play ", diceValue1);
                    break;
                case LADDER:
                    positionplayer1 = positionplayer1 + diceValue1;
                    Console.WriteLine("Dice value get: {0} and When get Ladder ", diceValue1);
                    if (positionplayer1 > 100)
                    {
                        positionplayer1 = positionplayer1 - diceValue1;
                    }
                    break;
                case SNAKE:
                    positionplayer1 = positionplayer1 - diceValue1;
                    Console.WriteLine("Dice value get: {0} and When get Snake ", diceValue1);
                    if (positionplayer1 < 0)
                    {
                        positionplayer1 = 0;
                    }
                    break;
            }
            Console.WriteLine("Player1 current position: {0} and Dice Roll Count for Player1: {1} ", positionplayer1, diceRollCountP1);
            Console.WriteLine("----------------------------------------------------------------");
            if (positionplayer1 == 100)
            {
                Console.WriteLine("<==============>Player 1 Won The Game<===============>");
                break;
            }

            int diceValue2 = random.Next(1, 7);
            Console.WriteLine("PLAYER2 -----> ");
            int option2 = random.Next(0, 3);
            diceRollCountP2++;
            switch (option2)
            {
                case NO_PLAY:
                    Console.WriteLine("Dice value get: {0} and When No Play ", diceValue2);
                    break;
                case LADDER:
                    positionplayer2 = positionplayer2 + diceValue2;
                    Console.WriteLine("Dice value get: {0} and When get Ladder ", diceValue2);
                    if (positionplayer2 > 100)
                    {
                        positionplayer2 = positionplayer2 - diceValue2;
                    }
                    break;
                case SNAKE:
                    positionplayer2 = positionplayer2 - diceValue2;
                    Console.WriteLine("Dice value get: {0} and When get Snake ", diceValue2);
                    if (positionplayer2 < 0)
                    {
                        positionplayer2 = 0;
                    }
                    break;
            }
            Console.WriteLine("Player2 current position: {0} and Dice Roll Count for Player2: {1} ", positionplayer2, diceRollCountP2);
            Console.WriteLine("---------------------------------------------------------------");
            if (positionplayer2 == 100)
            {
                Console.WriteLine("<==============>Player 2 Won The Game<===============>");
                break;
            }
        }
    }
}