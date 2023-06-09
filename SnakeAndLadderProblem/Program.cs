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
                Console.WriteLine("\nSelect option \n1.Start Game \n2.Player1 roll dice \n3.Exit");
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
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}