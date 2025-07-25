using System;
using Assignment_6_OOP.First__Project;
class program
{
    static void Main(string[] args)
    {
        #region First Project
        Point3D p = new Point3D(10, 10, 10);
        Console.WriteLine(p.ToString());


        Point3D p1 = ReadPointFromUser("P1");
        Point3D p2 = ReadPointFromUser("P2");


        if (p1 == p2)
            Console.WriteLine("P1 and P2 are equal.");
        else
            Console.WriteLine("P1 and P2 are NOT equal.");


        Point3D[] points = new Point3D[]
        {
            new Point3D(2, 3, 1),
            new Point3D(1, 5, 9),
            new Point3D(2, 1, 0),
            new Point3D(0, 0, 0)
        };

        Array.Sort(points);

        Console.WriteLine("\nSorted Points by X then Y:");
        foreach (Point3D point in points)
        {
            Console.WriteLine(point);
        }


        Point3D clone = (Point3D)p1.Clone();
        Console.WriteLine($"\nCloned P1: {clone}");
    }

    static Point3D ReadPointFromUser(string name)
    {
        int x = ReadInt($"{name} - Enter X: ");
        int y = ReadInt($"{name} - Enter Y: ");
        int z = ReadInt($"{name} - Enter Z: ");
        return new Point3D(x, y, z);
    }


    static int ReadInt(string message)
    {
        int value;
        Console.Write(message);
        while (!int.TryParse(Console.ReadLine(), out value))
        {
            Console.Write("Invalid input. Try again: ");
        }
        return value;


        #endregion

    }

} 

