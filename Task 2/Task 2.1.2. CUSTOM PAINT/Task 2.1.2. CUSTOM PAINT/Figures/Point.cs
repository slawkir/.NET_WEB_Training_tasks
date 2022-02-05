using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2._CUSTOM_PAINT
{
     class Point 
    {
        private int x;
        private int y;

        public Point(int x, int y) //конструктор центра
        {
            X = x;
            Y = y;
        }
        public Point() { } // пустой конструктор точки
        public int X
        {
            get
            { 
            return x;
            }
            set 
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public string ShowInfFigure()
        {
            return ($"\nЭто объект класса Point:" +
                $"\nкоординаты точки - X = {X} и Y = {Y}");
        }

    }
}
