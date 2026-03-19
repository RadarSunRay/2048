namespace _2048
{
    public class MoveBoard : IMoveBoard
    {
        public void Moving(IProjectgame projectgame, IDrawBoard drawBoard)
        {
            var board = projectgame.board;

            switch (projectgame.Move)
            {
                case Move.Left:
                    {
                        for (int i = 0; i < board.GetLength(0); i++) // строка
                        {
                            for (int j = 1; j < board.GetLength(1); j++) // столбец
                            {
                                if (board[i, j] == 0) continue;
                                int currentJ = j;

                                while (currentJ - 1 >= 0 && board[i, currentJ - 1] == 0)
                                {
                                    board[i, currentJ - 1] = board[i, currentJ];
                                    board[i, currentJ] = 0;
                                    currentJ--;
                                    Thread.Sleep(100);
                                    drawBoard.DrawBoard(projectgame);
                                }
                                if (currentJ - 1 < 0) continue;
                                if (board[i, currentJ - 1] == board[i, currentJ])
                                {
                                    board[i, currentJ - 1] = board[i, currentJ - 1] * 2;
                                    board[i, currentJ] = 0;
                                    projectgame.Score += board[i, currentJ - 1];
                                    Thread.Sleep(100);
                                    drawBoard.DrawBoard(projectgame);
                                }
                                if (board[i, currentJ - 1] == 2048)
                                {
                                    projectgame.HasWon = true;
                                }
                            }
                        }

                        break;
                    }
                case Move.Right:
                    {
                        for (int i = 0; i < board.GetLength(0); i++)
                        {
                            for (int j = board.GetLength(1) - 1; j >= 0; j--)
                            {
                                if (board[i, j] == 0) continue;

                                int currentJ = j;

                                while (currentJ + 1 < board.GetLength(1) && board[i, currentJ + 1] == 0)
                                {
                                    board[i, currentJ + 1] = board[i, currentJ];
                                    board[i, currentJ] = 0;
                                    currentJ++;
                                    Thread.Sleep(100);
                                    drawBoard.DrawBoard(projectgame);
                                }
                                if (currentJ + 1 >= board.GetLength(1)) continue;
                                if (board[i, currentJ + 1] == board[i, currentJ])
                                {
                                    board[i, currentJ + 1] = board[i, currentJ + 1] * 2;
                                    board[i, currentJ] = 0;
                                    projectgame.Score += board[i, currentJ + 1];
                                    Thread.Sleep(100);
                                    drawBoard.DrawBoard(projectgame);
                                }
                                if (board[i, currentJ + 1] == 2048)
                                {
                                    projectgame.HasWon = true;
                                }
                            }
                        }
                        break;
                    }
                case Move.Up:
                    {
                        for (int i = 1; i < board.GetLength(0); i++) // строка
                        {
                            for (int j = 0; j < board.GetLength(1); j++) // столбец
                            {
                                if (board[i, j] == 0) continue;
                                int currentI = i;

                                while (currentI - 1 >= 0 && board[currentI - 1, j] == 0)
                                {
                                    board[currentI - 1, j] = board[currentI, j];
                                    board[currentI, j] = 0;
                                    currentI--;
                                    Thread.Sleep(100);
                                    drawBoard.DrawBoard(projectgame);
                                }
                                if (currentI - 1 < 0) continue;
                                if (board[currentI - 1, j] == board[currentI, j])
                                {
                                    board[currentI - 1, j] = board[currentI - 1, j] * 2;
                                    board[currentI, j] = 0;
                                    projectgame.Score += board[currentI - 1, j];
                                    Thread.Sleep(100);
                                    drawBoard.DrawBoard(projectgame);
                                }
                                if (board[currentI - 1, j] == 2048)
                                {
                                    projectgame.HasWon = true;
                                }
                            }
                        }
                        break;
                    }
                case Move.Down:
                    {
                        for (int i = board.GetLength(0) - 1; i >= 0; i--) // строка
                        {
                            for (int j = 0; j < board.GetLength(1); j++) // столбец
                            {
                                if (board[i, j] == 0) continue;
                                int currentI = i;

                                while (currentI + 1 < board.GetLength(0) && board[currentI + 1, j] == 0)
                                {
                                    board[currentI + 1, j] = board[currentI, j];
                                    board[currentI, j] = 0;
                                    currentI++;
                                    Thread.Sleep(100);
                                    drawBoard.DrawBoard(projectgame);
                                }
                                if (currentI + 1 >= board.GetLength(0)) continue;
                                if (board[currentI + 1, j] == board[currentI, j])
                                {
                                    board[currentI + 1, j] = board[currentI + 1, j] * 2;
                                    board[currentI, j] = 0;
                                    projectgame.Score += board[currentI + 1, j];
                                    Thread.Sleep(100);
                                    drawBoard.DrawBoard(projectgame);
                                }
                                if (board[currentI + 1, j] == 2048)
                                {
                                    projectgame.HasWon = true;
                                }
                            }
                        }
                        break;
                    }
            }
            if (projectgame.Score > projectgame.BestScore)
            {
                projectgame.BestScore = projectgame.Score;
            }
        }
    }
}
