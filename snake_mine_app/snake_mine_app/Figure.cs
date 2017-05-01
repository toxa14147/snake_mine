using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_mine_app
{
    class Figure
    {
       protected List<Point> plist;
        public void Drow()
        {
            foreach (Point p in plist)
            {
                p.Draw();
            }
        }

    }
}
