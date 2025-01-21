using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews
{
    abstract class Shape
    {

        // abstract method
        // No direct access
        public abstract double area();

        public void PrintName()
        {
            Console.Write("PrintName method called ");
        }
    }

    class Square : Shape
    {

        // private data member
        private int side;

        // method of square class
        public Square(int x = 0)
        {
            side = x;
        }

        // overriding of the abstract method of Shape
        // class using the override keyword
        public override double area()
        {
            Console.Write("Area of Square: ");
            return (side * side);
        }

        public void PrintName()
        {
            Console.Write("PrintName method called ");
        }
    }

    class Circle : Shape
    {
        private int radius;
        public Circle(int _radius)
        {
            this.radius = _radius;
        }
        public override double area()
        {
            Console.Write("Area of Circle: ");
            return (Math.PI * this.radius * this.radius);
        }
    }

    class Abstract
    {
        static void Main1(string[] args)
        {

            // creating reference of Shape class
            // which refer to Square class instance
            Shape sh = new Square(4);

            // calling the method
            double result = sh.area();

            Console.Write("{0}", result);

            Circle circle = new Circle(4);
            double result1 = circle.area();

            Console.Write("{0}", result1);


            Console.ReadLine();

        }
    }

}