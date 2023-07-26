using System;

namespace Lab2Q2
{
    internal class Program
    {
        class Point3D
        {
            public int X;
            public int Y;
            public int Z;

            public Point3D() : this(1, 2, 3)
            {
                //X = 1;
                //Y = 2;
                //Z = 3;
            }
            public Point3D(int x) : this(x, 2, 3)
            {
                //X = x;
                //Y = 2;
                //Z = 3;
            }
            public Point3D(int x, int y, int z)
            {
                X = x;
                Y = y;
                Z = z;
            }

            public void Display()
            {
                Console.WriteLine($"X Coordinate:{X}, Y Coordinate:{Y}, Z Coordinate:{Z}");
            }

            public void ChangeCoordinates(int newX,int newY,int newZ)
            {
                X = newX;
                Y = newY;
                Z = newZ;
            }
        }
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D(1);
            Point3D p2 = new Point3D(1, 2, 3);
            Console.Write("p1:  "); 
            p1.Display();
            Console.Write("p2:  ");
            p2.Display();

            if (p1 == p2)
                Console.WriteLine("p1 and p2 are references to the same object");
            else
                Console.WriteLine("p1 and p2 are references to different objects");


            p1.ChangeCoordinates(4, 5, 6);
            Console.WriteLine("\n\nAfter changing p1:");
            Console.Write("p1:  ");
            p1.Display(); 
            Console.Write("p2:  ");
            p2.Display();
            p2 = p1;
            Console.WriteLine("\n\nAfter writing p2 = p1 ");
            Console.Write("p1:  ");
            p1.Display();
            Console.Write("p2:  ");
            p2.Display();

            if (p1 == p2)
                Console.WriteLine("p1 and p2 are references to the same object");
            else
                Console.WriteLine("p1 and p2 are references to different objects");
        }
    }
}