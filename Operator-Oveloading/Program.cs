using System;

namespace Operator_Overloading
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // Operator Overloading

        public static Point operator +(Point a, Point b) => new Point(a.X + b.X, a.Y + b.Y, a.Z + b.Z);

        public static Point operator -(Point a, Point b) => new Point(a.X - b.X, a.Y - b.Y, a.Z - b.Z);

        public static Point operator *(Point a, int scalar) => new Point(a.X * scalar, a.Y * scalar, a.Z * scalar);

        public static Point operator *(int scalar, Point a) => a * scalar;

        public static Point operator /(Point a, int scalar) => new Point(a.X / scalar, a.Y / scalar, a.Z / scalar);

        public static Point operator ++(Point a) => new Point(a.X + 1, a.Y + 1, a.Z + 1);

        public static Point operator --(Point a) => new Point(a.X - 1, a.Y - 1, a.Z - 1);

        public static bool operator ==(Point a, Point b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }

        public static bool operator !=(Point a, Point b) => !(a == b);

        public static bool operator <(Point a, Point b) 
            => (a.X * a.X + a.Y * a.Y + a.Z * a.Z) < (b.X * b.X + b.Y * b.Y + b.Z * b.Z);

        public static bool operator >(Point a, Point b)
            => (a.X * a.X + a.Y * a.Y + a.Z * a.Z) > (b.X * b.X + b.Y * b.Y + b.Z * b.Z);

        public static bool operator <=(Point a, Point b)  => !(a > b);

        public static bool operator >=(Point a, Point b) => !(a < b);

        public override bool Equals(object obj)
        {
            if (obj is Point other)
                return this == other;
            return false;
        }

        public override int GetHashCode() => (X, Y, Z).GetHashCode();

        public override string ToString() => $"({X}, {Y}, {Z})";
    }

    class Program
    {
        static void Main()
        {
            Point point1 = new Point(2, 3, 4);
            Point point2 = new Point(3, 4, 5);

            Point sum = point1 + point2;
            Point diff = point1 - point2;
            Point scaled = point1 * 3;
            Point div = point2 / 2;
           // Point incremented = ++point1;
           // Point decremented = --point2;

            Console.WriteLine($"point1 = {point1}");
            Console.WriteLine($"point2 = {point2}");
            Console.WriteLine($"sum = {sum}");
            Console.WriteLine($"diff = {diff}");
            Console.WriteLine($"scaled = {scaled}");
            Console.WriteLine($"div = {div}");
           // Console.WriteLine($"incremented = {incremented}");
           // Console.WriteLine($"decremented = {decremented}");

            Console.WriteLine($"point1 == point2: {point1 == point2}");
            Console.WriteLine($"point1 != point2: {point1 != point2}");
            Console.WriteLine($"point1 < point2: {point1 < point2}");
            Console.WriteLine($"point1 > point2: {point1 > point2}");
            Console.WriteLine($"point1 <= point2: {point1 <= point2}");
            Console.WriteLine($"point1 >= point2: {point1 >= point2}");
        
        }
    }
}
