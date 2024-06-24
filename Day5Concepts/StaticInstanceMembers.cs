using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Concepts.StaticInstanceMembersConcepts
{
    #region Static and Instance memebers example 1
    public class StaticInstanceMembers
    {
        /// <summary>
        /// Finding Area of a Circle using Static Constructor
        /// </summary>
        public void StaticMembersExample1()
        {
            Circle C1 = new Circle(5);

            float area1 = C1.CalculateArea();

            Console.WriteLine("Area1 = {0}", area1);

            Circle C2 = new Circle(6);

            float area2 = C2.CalculateArea();

            Console.WriteLine("Area2 = {0}", area2);
        }

        /// <summary>
        /// Finding Area of a Circle using Instance Constructor
        /// </summary>
        public void InstanceMembersExample1()
        {
            CircleA C1 = new CircleA(5);

            float area1 = C1.CalculateArea();

            Console.WriteLine("Area1 = {0}", area1);

            CircleA C2 = new CircleA(6);

            float area2 = C2.CalculateArea();

            Console.WriteLine("Area2 = {0}", area2);

        }
    }

    class Circle
    {
        float _PI = 3.141f;
        int _radius;

        public Circle (int radius)
        {
            this._radius = radius;
        }

        public float CalculateArea()
        {
            return this._PI * this._radius * this._radius;
        }
    }
    #endregion
    class CircleA
    {
        static float _PI = 3.141f;
        int _radiusA;

        static CircleA()
        {
            CircleA._PI = 3.141f;
        }

        public CircleA(int radiusA)
        {
            this._radiusA = radiusA;
        }

        public float CalculateArea()
        {
            return CircleA._PI * this._radiusA * this._radiusA;
        }
    }
}
