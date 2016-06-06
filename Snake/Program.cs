using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetBufferSize(80, 25);

            // Отрисовка рамки

            HorizontalLine lineUp = new HorizontalLine(0, 78, 0, '#');
            HorizontalLine lineDown = new HorizontalLine(0, 78, 24, '#');
            VerticalLine lineLeft = new VerticalLine(0, 0, 24, '#');
            VerticalLine lineRight = new VerticalLine(78, 0, 24, '#');
            lineUp.Draw();
            lineDown.Draw();
            lineLeft.Draw();
            lineRight.Draw();

            // Отрисовка точки в рамке
            Point p = new Point(3, 5, '*');
            Snake snake = new Snake(p, 4, direction.RIGHT);
            snake.Draw();

                                      
             
            Console.ReadLine();

        }
        
    }
}
