using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class tochka
    {
        int x;
        int y;
        char s;

        public void SetX(int x)
        {
            if (x >= 0)
                this.x = x;
            else
                throw new Exception("x не может быть отрицательным");
        }
        public void SetY(int y)
        {
            if (y >= 0)
                this.y = y;
            else
                throw new Exception("y не может быть отрицательным");
        }
        public tochka(int x, int y, char s)
        {
            this.x = x;
            this.y = y;
            this.s = s;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }

    }
    class pryamougolnik
    {
        protected List<tochka> tList;
        public void Draw()
        {
            foreach (tochka t in tList)
            {
                t.Draw();
            }
        }
    }
    class vertikal : pryamougolnik
    {
        public vertikal(int yv, int yn, int x, char s)
        {
            tList = new List<tochka>();
            for (int y = yv; y <= yn; y++)
            {
                tochka t = new tochka(x, y, s);
                tList.Add(t);
            }
        }
    }
    class horizontal : pryamougolnik
    {
        public horizontal(int xl, int xp, int y, char s)
        {
            tList = new List<tochka>();
            for (int x = xl; x <= xp; x++)
            {
                tochka t = new tochka(x, y, s);
                tList.Add(t);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            horizontal h1 = new horizontal(1, 25, 5, '*');
            h1.Draw();
            horizontal h2 = new horizontal(1, 25, 10, '*');
            h2.Draw();
            vertikal v1 = new vertikal(5, 10, 1, '*');
            v1.Draw();
            vertikal v2 = new vertikal(5, 10, 25, '*');
            v2.Draw();
            Console.ReadKey();
        }
    }
}
//        public void SetS(char sym)
//        {
//            s = sym;
//        }
//        public void Draw(int x, int y)
//        {
//            Console.SetCursorPosition(x, y);
//            Console.Write(s);
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            tochka t = new tochka();
//            int x = Convert.ToInt16(Console.ReadLine());
//            int y = Convert.ToInt16(Console.ReadLine());
//            t.SetX(x);
//            t.SetY(y);
//            t.SetS('(');
//            t.Draw(x, y);
//            t.SetX(x++);
//            t.SetY(y);
//            t.SetS(')');
//            t.Draw(x,y);
//            t.SetX(x);
//            t.SetY(y++);
//            t.SetS('|');
//            t.Draw(x, y);
//            t.SetX(x--);
//            t.SetY(y);
//            t.SetS('|');
//            t.Draw(x, y);
//            t.SetX(x);
//            t.SetY(y++);
//            t.SetS('/');
//            t.Draw(x, y);
//            t.SetX(x++);
//            t.SetY(y);
//            t.SetS('\\');
//            t.Draw(x, y);
//            Console.ReadKey();
//        }



//    }
//}

