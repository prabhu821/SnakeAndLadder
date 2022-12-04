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
                Console.WriteLine("1.GameStart \n2.Roll Dice \n3.Checking Position \n4.Exit");
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
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}