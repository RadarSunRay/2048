namespace _2048
{
    public class RandomBoard : IRandomBoard
    {
        public void RandomNumGame(IProjectgame projectGame, IRandom random)
        {
            int x, y;
            int count = 2;
            do
            {
                x = random.Next(projectGame.Size);
                y = random.Next(projectGame.Size);
                if (projectGame.board[x, y] == projectGame.Num)
                {
                    continue;
                }
                projectGame.board[x, y] = projectGame.Num;
                count--;
            } while (count > 0);
        }
        public void RandomNumBoard(IDrawBoard drawBoard, IRandom random, IProjectgame projectGame, IGameOver gameOver)
        {
            if (!gameOver.FoundEmprtySpace(projectGame)) return;
            int x, y;
            int count = 1;
            do
            {
                x = random.Next(projectGame.Size);
                y = random.Next(projectGame.Size);
                if (projectGame.board[x, y] != 0)
                {
                    continue;
                }

                projectGame.board[x, y] = projectGame.Num;
                count--;
            } while (count > 0);
        }
    }
}
