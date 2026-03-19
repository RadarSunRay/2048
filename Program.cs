using System.Drawing;

namespace _2048
{
    internal class Program
    {

       
        static void Main(string[] args)
        {
            IDrawBoard drawBoard = new Board();
            IGameOver gameOver = new GameOverOrWon();
            IMoveBoard moveBoard = new MoveBoard();
            IProjectgame game = new ProjectGame();
            IRandom random = new MyRandom();
            IRandomBoard randomBoard = new RandomBoard();
            IConsoleInput consoleInput = new ConsoleInput();
            GameLogger gameLogger = new GameLogger(game, drawBoard, randomBoard,consoleInput,moveBoard,random,gameOver);
            gameLogger.Game();
        }
    }
}
