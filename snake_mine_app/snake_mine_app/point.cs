using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_mine_app
{
    class point
    { //координаты
        public int x;
        public int y;
        public char sym;
        //задаём точку с координатами х у z
        public point(int _x, int _y, char _sym) {
            x = _x;
            y = _y;
            sym = _sym;
        }
        //задаём перемещение точке
        public point(point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        //рисуем точку
        public void Drow()
        {
            Console.SetWindowPosition(x, y);
            Console.Write(sym);
        }
        //зачищаем точки
        public void Clear()
        {
            char sym = ' ';
            Console.Write(sym);
        }
    }
    
}
