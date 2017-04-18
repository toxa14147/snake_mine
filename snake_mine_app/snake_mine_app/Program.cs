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
        {//размер окна
            Console.SetBufferSize(80, 85);
            //стартовая точка р
            point p = new point(1,3,'*');
        }
    }
}
