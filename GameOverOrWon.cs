using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    public class GameOverOrWon : IGameOver
    {
        public void GameWon(IProjectgame projectgame, IRandomBoard randomboard, IRandom random)
        {
            SaveScore.Save(projectgame.BestScore);
            Console.WriteLine("\nИгра окончена");
            while (true)
            {
                Console.WriteLine("Хотите продолжить игру?\nДа/Нет");
                string? game = Console.ReadLine();
                switch (game)
                {
                    case string s when s.Equals("Да", StringComparison.OrdinalIgnoreCase):
                        {
                            projectgame.HasWon = false;
                            projectgame.HasLose = false;
                            projectgame.Score = 0;
                            projectgame.board = new int[projectgame.Size, projectgame.Size];
                            randomboard.RandomNumGame(projectgame, random);
                            return;
                        }
                    case string s when s.Equals("Нет", StringComparison.OrdinalIgnoreCase):
                        {
                            return;
                        }
                    default:
                        {
                            Console.Clear();
                            break;
                        }
                }
            }
        }
        public bool GameOver(IProjectgame projectgame)
        {
            for (int i = 0; i < projectgame.board.GetLength(0); i++)
            {
                for (int j = 0; j < projectgame.board.GetLength(1); j++)
                {
                    if (projectgame.board[i, j] == 0) return false;
                    if (i + 1 < projectgame.board.GetLength(0) && projectgame.board[i + 1, j] == projectgame.board[i, j]) return false;
                    if (j + 1 < projectgame.board.GetLength(1) && projectgame.board[i, j + 1] == projectgame.board[i, j]) return false;
                }
            }
            return true;
        }
        public bool FoundEmprtySpace(IProjectgame projectgame)
        {
            for (int i = 0; i < projectgame.board.GetLength(0); i++)
            {
                for (int j = 0; j < projectgame.board.GetLength(1); j++)
                {
                    if (projectgame.board[i, j] == 0) return true;
                }
            }
            return false;
        }
    }
}
