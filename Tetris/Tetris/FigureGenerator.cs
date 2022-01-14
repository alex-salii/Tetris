using Tetris;

namespace MyApp
{
    internal class FigureGenerator
    {
        private int _x;
        private int _y;
        private char _c;

        private Random _rend = new Random();

        public FigureGenerator(int x, int y, char c)
        {
            _x = x;
            _y = y;
            _c = c;

            
        }

        public Figure GetNewFigure()
        {
            if (_rend.Next(0, 2) == 0)
                return new Square(_x, _y, _c);
            else
                return new Stick(_x, _y, _c);
        }
    }
}