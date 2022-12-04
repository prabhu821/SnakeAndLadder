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
                Console.WriteLine("1.GameStart \n2.Exit");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        GamePlay game = new GamePlay();
                        game.Start();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}