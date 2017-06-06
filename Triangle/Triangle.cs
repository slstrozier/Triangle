using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public enum TriangleType
    {
        Scalene, Isosceles, Equilateral, Invalid
    }
    public class Triangle
    {
        public static TriangleType GetTriangleType(int a, int b, int c)
        {
            List<int> angles = new List<int>() { a, b, c };
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return TriangleType.Invalid;
            }
            if (angles.Distinct().Count() == 1)
            {
                return TriangleType.Equilateral;
            }
            else if (angles.Distinct().Count() == 2)
            {
                return TriangleType.Isosceles;
            }
            else if (angles.Distinct().Count() == 3)
            {
                return TriangleType.Scalene;
            }
            else
            {
                return TriangleType.Invalid;
            }
           
        }
    }
}
