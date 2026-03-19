using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    public interface IDrawBoard
    {
        public void DrawBoard(IProjectgame projectgame);
        public void DrawFrame(Point l, Size s);
        public Point l { get; set; }
    }
}
