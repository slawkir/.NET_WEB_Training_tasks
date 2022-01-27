using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2._Game_Development
{
    public struct Point
    {
        public int X { get; init; }
        public int Y { get; init; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            return obj is Point point && X == point.X && Y == point.Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        public static bool operator ==(Point left, Point right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Point left, Point right)
        {
            return !(left == right);
        }
        public static Point Zero => new(0, 0);

        public override string ToString() // переопределение к строке для передачи в Player
        {
            return $"({X} , {Y})";
        }
    }
}
