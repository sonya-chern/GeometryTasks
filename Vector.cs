using System;

namespace GeometryTasks
{
    public class Vector
    {
        public double X;
        public double Y;
    }
    public class Geometry
    {
        public static double GetLength(Vector vec)
        {
            return Math.Sqrt(vec.X * vec.X + vec.Y * vec.Y);
        }

        public static double GetLength(Segment seg)
        {
            return Math.Sqrt(Math.Pow((seg.End.X - seg.Begin.X), 2) + Math.Pow((seg.End.Y - seg.Begin.Y), 2));
        }

        public bool IsVectorInSegment(Vector vec, Segment seg)
        {
            var rez1 = Math.Sqrt(Math.Pow((vec.X- seg.Begin.X), 2) + Math.Pow((vec.Y - seg.Begin.Y), 2));
            var rez2 = Math.Sqrt(Math.Pow((seg.End.X - vec.X), 2) + Math.Pow((seg.End.Y - vec.Y), 2));
            return GetLength(seg) == rez1 + rez2;
        }

        public static Vector Add(Vector vecOne, Vector vecTwo)
        {
            return new Vector() { X = vecOne.X + vecTwo.X, Y = vecOne.Y + vecTwo.Y };
        }
    }
}
