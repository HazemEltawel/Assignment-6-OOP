using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_OOP.First__Project
{
    public class Point3D : IComparable<Point3D>, IComparable
    {

        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public Point3D() : this(0, 0, 0) { }
        public Point3D(int value) : this(value, value, value) { }
        public Point3D(int X, int Y, int Z)
        {
            x = X;
            y = Y;
            z = Z;
        }
        public override string ToString()
        {
            return $"({x}, {y}, {z})";
        }
        public override bool Equals(object? obj)
        {
            if (obj is Point3D other)
            {
                return x == other.x && y == other.y && z == other.z;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(x, y, z);
        }
        public static bool operator ==(Point3D left, Point3D right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(Point3D left, Point3D right)
        {
            return !(left == right);
        }


        public int CompareTo(Point3D? other)
        {
            if (other == null) return 1; 
            int result = x.CompareTo(other.x);
            if (result != 0) return result;
            result = y.CompareTo(other.y);
            if (result != 0) return result;
            return z.CompareTo(other.z);
        }

        public int CompareTo(object? obj)
        {
            if (obj == null) return 1;
            if (obj is Point3D other)
            {
                return CompareTo(other);
            }
            throw new ArgumentException("Object is not a Point3D");
        }
        public object Clone()
        {
            return new Point3D(x, y, z);
        }
    }
}
