using System;

namespace TriangleClass
{
    public class Triangle
    {

        public  int SideA { get; set; }
        public  int SideB { get; set; }
        public int SideC { get; set; }

        public Triangle (int lenght1, int lenght2, int lenght3)
        {
            SideA = lenght1;
            SideB = lenght2;
            SideC = lenght3;

        }

        public  static string Analyzemethod(Triangle triangle)
        {
            if (triangle.SideA < 1 ||triangle.SideB < 1 || triangle.SideC < 1 || triangle.SideA > 200 || triangle.SideB > 200 || triangle.SideC > 200)
            {
                throw new InvalidException();

            }

            else if (triangle.SideA >= triangle.SideB + triangle.SideC || triangle.SideB >= triangle.SideC + triangle.SideA || triangle.SideC >= triangle.SideB + triangle.SideA)
            {
                return "Not a Triangle";
            }
            else if (triangle.SideA == triangle.SideB && triangle.SideB == triangle.SideC && triangle.SideA == triangle.SideC)
            {
                return "Equilateral";
            }
            else if (triangle.SideA == triangle.SideB || triangle.SideA == triangle.SideC || triangle.SideB == triangle.SideC)
            {
                return "isoceles";
            }
            else
            {
                return "scalene";

            }




        }
    }



    public class InvalidException : Exception
    {
        public InvalidException()
        {
        }
        public InvalidException(string message)
            : base(message)
        {
        }

        public InvalidException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
