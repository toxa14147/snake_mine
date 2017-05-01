using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_mine_app
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.SetBufferSize(85, 25);
            HorisontalLine lineUp = new HorisontalLine(2, 84, 2, '+');
            HorisontalLine lineDown = new HorisontalLine(2, 84, 24, '+');
            VerticalLine lineLeft = new VerticalLine(2, 23, 2, '+');
            VerticalLine lineRight = new VerticalLine(2, 23, 84, '+');

            lineUp.Drow();
            lineDown.Drow();
            lineLeft.Drow();
            lineRight.Drow();
            Point p = new Point(4, 6, '*');
            Snake snake = new Snake(p, 4, Direclion.RIGHT );
            snake.Drow();
            snake.Move();
            Console.ReadLine();
        }
    }
}
