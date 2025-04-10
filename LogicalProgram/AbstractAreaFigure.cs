using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public abstract class TestFigure
    {
        public const float pi = 3.14f;
        public double width, height, radius;
        public abstract double GetArea();
    }
    public class Cone : TestFigure
    {
        public Cone(double height, double radius) 
        {
            this.height = height;
            base.width = radius;
        }
        public override double GetArea()
        {
            return pi * radius * (radius + Math.Sqrt((height * height) + (radius * radius)));
        }
    }
    public class Circle : TestFigure
    {
        public Circle(double radius)
        {
            this.radius = radius;           
        }
        public override double GetArea()
        {
            return radius * radius * pi;
        }
    }    
    public class Triangle : TestFigure
    {
        public Triangle(double Base, double height)
        {
            this.height = height;
            base.width = Base;
        }
        public override double GetArea()
        {
            return height * radius * 0.5;
        }
    }
    public class Rectangle : TestFigure 
    {
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double GetArea()
        {
            return width * height;
        }
    }
    public class AbstractAreaFigure
    {
        static void Main()
        {
            Cone cone = new Cone(23.34, 12.23);
            Console.WriteLine($"Area of Cone is : {cone.GetArea()}");
            Circle circle = new Circle(23.23);
            Console.WriteLine($"Area of Circle is : {circle.GetArea()}");
            Triangle tri = new Triangle(23.34, 23.23);
            Console.WriteLine($"Area of Traingle is : {tri.GetArea()}");
            Rectangle rect = new Rectangle(34.34, 23.65);
            Console.WriteLine($"Area of Rectangle is : {rect.GetArea()}");
        }
    }

}
