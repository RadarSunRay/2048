namespace _2048
{
    public class ConsoleInput : IConsoleInput
    {
        public Move MoveLogger()
        {
            ConsoleKey moving = Console.ReadKey(true).Key;
            Move move = new();
            switch (moving)
            {
                case ConsoleKey.LeftArrow:
                    move = Move.Left;
                    break;
                case ConsoleKey.RightArrow:
                    move = Move.Right;
                    break;
                case ConsoleKey.UpArrow:
                    move = Move.Up;
                    break;
                case ConsoleKey.DownArrow:
                    move = Move.Down;
                    break;
            }
            return move;
        }
    }
}
