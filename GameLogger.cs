using System.Drawing;

namespace _2048
{
    public class GameLogger
    {
        private readonly IProjectgame projectgame;
        private readonly IDrawBoard drawBoard;
        private readonly IRandomBoard random;
        private readonly IConsoleInput consoleInput;
        private readonly IMoveBoard move;
        private readonly IRandom randomNum;
        private readonly IGameOver gameOver;
        public GameLogger (IProjectgame projectgame, IDrawBoard drawBoard, IRandomBoard random, IConsoleInput consoleInput, IMoveBoard move, IRandom randomNum, IGameOver gameOver)
        {
            this.projectgame = projectgame;
            this.drawBoard = drawBoard;
            this.random = random;
            this.consoleInput = consoleInput;
            this.move = move;
            this.randomNum = randomNum;
            this.gameOver = gameOver;
        }
        public void Game()
        {
            projectgame.SetScore(SaveScore.GetScore());
            random.RandomNumGame(projectgame, randomNum);
            drawBoard.DrawFrame(new Point(48, 4), new Size(27, 5));
            drawBoard.l = new Point(50, 5);
            while (!projectgame.HasWon && !projectgame.HasLose)
            {
                drawBoard.DrawBoard(projectgame);
                projectgame.Move = consoleInput.MoveLogger();
                move.Moving(projectgame, drawBoard);
                projectgame.HasLose = gameOver.GameOver(projectgame);
                if (projectgame.HasWon || projectgame.HasLose)
                {
                    gameOver.GameWon(projectgame, random, randomNum);
                }
                random.RandomNumBoard(drawBoard, randomNum, projectgame, gameOver);
            }
        }
    }
}
