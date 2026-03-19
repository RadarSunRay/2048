using System.Drawing;

namespace _2048
{
    public class ProjectGame : IProjectgame
    {
        public int Size { get; set; } = 4;
        public int Num { get; set; } = 2;
        public int[,] board { get; set; } 
        public Move Move { get; set; }
        public int Score { get; set; } = 0;
        public int BestScore { get; set; } = 0;
        public bool HasWon { get; set; } = false;
        public bool HasLose { get; set; } = false;
        public ProjectGame()
        {
            board = new int[Size, Size];
        }
        public void SetScore(int score)
        {
            BestScore = score;
        }
    }
}
