using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    public interface IGameOver
    {
        public void GameWon(IProjectgame projectgame, IRandomBoard randomboard, IRandom random);
        public bool GameOver(IProjectgame projectgame);
        public bool FoundEmprtySpace(IProjectgame projectgame);
    }
}
