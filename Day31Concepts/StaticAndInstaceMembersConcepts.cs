using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day31Concepts.StaticAndInstaceMembersConcepts
{
    public class StaticAndInstaceMembers
    {
        public static void InstaceMembersExample()
        {
            Circle C1 = new Circle(5);
            float area = C1.CalculateArea();
            Console.WriteLine("Area is " + area);

            Circle C2 = new Circle(10);
            float area2 = C2.CalculateArea();
            Console.WriteLine("Area is " + area2);
        }

        public static void StaticMembersExample()
        {
            CircleA C1 = new CircleA(5);
            float area = C1.CalculateArea();
            Console.WriteLine("Area is " + area);

            CircleA C2 = new CircleA(10);
            float area2 = C2.CalculateArea();
            Console.WriteLine("Area is " + area2);
        }
    }

    public class Circle
    {
        float _pI = 3.14f;
        int _radius;

        public Circle(int radius)
        {
            this._radius = radius;
        }

        public float CalculateArea()
        {
            return this._pI * this._radius * this._radius;
        }
    }

    public class CircleA
    {
        static float _pI = 3.14f;
        int _radius;

        public CircleA(int radius)
        {
            this._radius = radius;
        }

        public float CalculateArea()
        {
            return _pI * this._radius * this._radius;
        }
    }
}
   