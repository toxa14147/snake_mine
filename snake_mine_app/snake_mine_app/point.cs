﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_mine_app
{
    class Point
    {
        public int x;
        public int y;
        public char sym;
        public Point (int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
       
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        public void Move(int offset,Direclion direction)
        {
            if(direction == Direclion.RIGHT)
            {
                x = x + offset ;
            } else if(direction == Direclion.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direclion.UP)
            {
                y = y + offset;
            }
            else if (direction == Direclion.DOWN)
            {
                y = y - offset;
            }
            
        }

        
        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}
