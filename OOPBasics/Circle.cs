//Stina Hedman
//NET23

using System;
using System.Collections.Generic;

namespace OOPBasics
{
    internal class Circle
    {

        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }
        public double GetRadius()
        {
            return _radius;
        }
        public void SetRadius(int radius)
        {
            _radius = radius;
        }

        public double GetArea()
        {
            return ( _radius * _radius  * Math.PI );
        }

        public double GetCircumfurence()
        {
            return Math.Sqrt(_radius * _radius);
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Circle> circleList = new List<Circle>();
            circleList.Add(new Circle(5));
            circleList.Add(new Circle(6));

            for (int i = 0; i < circleList.Count; i++)
            {
                Console.WriteLine($"Arean på en cirkel med radien : {circleList[i].GetRadius()} är : {circleList[i].GetArea()}");
            }
        }
    }

}
