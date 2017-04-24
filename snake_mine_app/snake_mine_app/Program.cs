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
            Console.SetBufferSize(85, 85);
            HorisontalLine lineUp = new HorisontalLine(2,80,2,'+');
            HorisontalLine lineDown = new HorisontalLine(2,80,80,'+');
            VerticalLine lineLeft = new VerticalLine(2, 80, 2, '+');
            VerticalLine lineRight = new VerticalLine(2, 80, 80, '+');
            lineUp.Drow();
            lineDown.Drow();
            lineLeft.Drow();
            lineRight.Drow();


            Console.ReadLine();
        }
    }
}
