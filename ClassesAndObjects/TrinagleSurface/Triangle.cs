/*      Problem 4. Triangle surface

    Write methods that calculate the surface of a triangle by given:
    Side and an altitude to it;
    Three sides;
    Two sides and an angle between them;
    Use System.Math.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinagleSurface
{
    class Triangle
    {
        static double sideAndAltitude(double side, double altitude)
        {
            double sum = (side * altitude) / 2;
            return sum;
        }
        static double threeSides(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double sum = Math.Sqrt(s * (s - a) * (s - b) * (s - c)); 
            return sum;
        }
        static double twoSidesAndAngle(double a, double b, int angle)
        {
            double sum = (a*b)/2*Math.Sin(angle);
            return sum;
        }
        static void ExitProgram()
        {
            Console.WriteLine("Goodbye!");
            Environment.Exit(0);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(new string('-',20));
                Console.WriteLine("Calculate area of triangle");
                Console.WriteLine("Press 1 for calculating by side and altitude!");
                Console.WriteLine("Press 2 for calculating by three sides!");
                Console.WriteLine("Press 3 for calculating by two sides and an angle between them!");
                Console.WriteLine("Press 0 to exit the program!");
                Console.WriteLine(new string('-',20));
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    if (input ==0)
                    {
                        ExitProgram();
                    }
                    else if (input ==1)
                    {
                        Console.Write("Enter side: ");
                        double side = double.Parse(Console.ReadLine());
                        Console.Write("Enter altitude: ");
                        double altitude = double.Parse(Console.ReadLine());
                        Console.WriteLine("Area = {0:F2}", sideAndAltitude(side, altitude));
                    }
                    else if (input == 2)
                    {
                        Console.Write("Enter side a, a= ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Enter side b, b= ");
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("Enter side c, c= ");
                        double c = double.Parse(Console.ReadLine());
                        Console.WriteLine("Area = {0:F2}",threeSides(a,b,c));
                    }
                    else if (input == 3)
                    {
                        Console.Write("Enter side a, a= ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Enter side b, b= ");
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("Enter angle= ");
                        int angle = int.Parse(Console.ReadLine());
                        Console.WriteLine("Area = {0:F2}",twoSidesAndAngle(a,b,angle));
                    }
                    else
                    {
                        Console.WriteLine("Wrong number :) , Lets pick again !");
                    }
                }
                catch  (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
