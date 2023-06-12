namespace SnakeAndLadderProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Problem !");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nSelect option \n1.Start Game \n2.Player1 roll dice \n3.Player Then Check Options " +
                    "\n4.Player Reaches the Winning Position \n5.Ensure Player Get Excat Winning Position \n6.Exit");
                int options = Convert.ToInt32(Console.ReadLine());
                Game game = new Game();
                switch (options)
                {
                    case 1:
                        game.GameStart();
                        break;
                    case 2:
                        game.PlayerRollsDice();
                        break;
                    case 3:
                        game.CheckOptions();
                        break;
                    case 4:
                        game.WinningPosition();
                        break;
                    case 5:
                        game.EnsurePlayerGetExcatWinningPosition();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}