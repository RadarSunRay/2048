using System.Drawing;

namespace _2048
{
    public class Board : IDrawBoard
    {
        public Point l { get; set; } = new(0, 0);
        public void DrawBoard(IProjectgame projectgame)
        {
            Point point = l;
            for (int i = 0; i < projectgame.Size; i++) // строка
            {
                for (int j = 0; j < projectgame.Size; j++) // столбец
                {
                    string cell = string.Empty;
                    if (projectgame.board[i, j] < 2)
                    {
                        cell = "[    ]";
                    }
                    else if (projectgame.board[i, j] < 10)
                    {
                        cell = $"[ {projectgame.board[i, j]}  ]";
                    }
                    else if (projectgame.board[i, j] < 100)
                    {
                        cell = $"[ {projectgame.board[i, j]} ]";
                    }
                    else if (projectgame.board[i, j] < 1000)
                    {
                        cell = $"[ {projectgame.board[i, j]}]";
                    }
                    else if (projectgame.board[i, j] < 10000)
                    {
                        cell = $"[{projectgame.board[i, j]}]";
                    }
                    SetCursorDraw(point, cell);
                    point.X = l.X + cell.Length * (j + 1);
                }
                point.Y++;
                point.X = l.X;
            }
            SetCursorDraw(new Point(point.X, point.Y + 1), $"Score: {projectgame.Score}");
            SetCursorDraw(new Point(point.X, point.Y + 2), $"Best Score: {projectgame.BestScore}");
        }
        private void SetCursorDraw(Point l, string c)
        {
            try
            {
                int needWidth = l.X + c.Length;
                if (Console.BufferWidth < needWidth)
                    Console.SetBufferSize(Math.Max(Console.BufferWidth, needWidth), Console.BufferHeight);
                if (Console.BufferHeight < l.Y)
                    Console.SetBufferSize(Console.BufferWidth, Math.Max(Console.BufferHeight, l.Y + 1));
                Console.SetCursorPosition(l.X, l.Y);
                Console.Write(c);
            }
            catch { }
        }
        const string FrameTopLeft = "╔";
        const string FrameTopRight = "╗";
        const string FrameBottomLeft = "╚";
        const string FrameBottomRight = "╝";

        const string FrameRow = "═";
        const string FrameCol = "║";

        public void DrawFrame(Point l, Size s)
        {
            SetCursorDraw(l, FrameTopLeft);
            SetCursorDraw(new Point(l.X + s.Width, l.Y), FrameTopRight);
            SetCursorDraw(new Point(l.X, l.Y + s.Height), FrameBottomLeft);
            SetCursorDraw(new Point(l.X + s.Width, l.Y + s.Height), FrameBottomRight);

            string line = new(Convert.ToChar(FrameRow), s.Width - 1);
            SetCursorDraw(new Point(l.X + 1, l.Y), line);
            SetCursorDraw(new Point(l.X + 1, l.Y + s.Height), line);

            for (int i = l.Y + 1; i < l.Y + s.Height; i++)
            {
                SetCursorDraw(new Point(l.X, i), FrameCol);
                SetCursorDraw(new Point(l.X + s.Width, i), FrameCol);
            }
        }
    }
}
