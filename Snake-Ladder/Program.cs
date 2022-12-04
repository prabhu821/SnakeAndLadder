namespace Snake_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nSnake And Ladder Game");
                Console.WriteLine("1.GameStart \n2.Roll Dice \n3.Checking Position " +
                    "\n4.Player Position Zero \n5.Player Position Exact 100 \n6.Position Of Dice Every Time Played " +
                    "\n7.Final Report Of 2 Players \n8.Exit");
                int options = Convert.ToInt32(Console.ReadLine());
                GamePlay game = new GamePlay();
                switch (options)
                {
                    case 1:
                        game.Start();
                        break;
                    case 2:
                        game.RollDice();
                        break;
                    case 3:
                        game.CheckingPlayerPosition();
                        break;
                    case 4:
                        game.PlayerPositionZeroRestart();
                        break;
                    case 5:
                        game.PlayerPositionExact100();
                        break;
                    case 6:
                        game.PositionOfDiceEveryTimePlayed();
                        break;
                    case 7:
                        game.FinalReportOf2Players();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}