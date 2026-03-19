using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    public interface IProjectgame
    {
        public int Size { get; set; }
        public  int Num { get; set; }
        public int[,] board {  get; set; }
        public Move Move { get; set; }
        public int Score { get; set; }
        public int BestScore { get; set; }
        public bool HasWon { get; set; }
        public bool HasLose { get; set; }
        public void SetScore(int score);
    }
}
