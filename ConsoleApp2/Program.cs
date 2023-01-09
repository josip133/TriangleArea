using System;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base of the triangle: ");
            double baza = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height of the triangle: ");
            double height = double.Parse(Console.ReadLine());

            double area = (baza * height) / 2;
            Console.WriteLine("The area of the triangle is: " + area);
        }
    }
}
