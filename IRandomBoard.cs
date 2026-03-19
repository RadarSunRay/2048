using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    public interface IRandomBoard
    {
        public void RandomNumGame(IProjectgame projectGame, IRandom random);
        public void RandomNumBoard(IDrawBoard drawBoard, IRandom random, IProjectgame projectGame, IGameOver gameOver);
    }
}
