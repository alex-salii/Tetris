using System;
using Tetris;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Square s = new Square(5, 7, '*');
            s.Draw();

            Point p1 = new Point(2, 3, '*');
            p1.Draw();

            Console.ReadLine();
        }
    }
}