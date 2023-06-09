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
                Console.WriteLine("\nSelect option \n1.GameStart \n2.Exit");
                int options = Convert.ToInt32(Console.ReadLine());
                Game game = new Game();
                switch (options)
                {
                    case 1:
                        game.GameStart();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}