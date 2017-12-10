using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _多态练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape square = new Square(24, 2);
            Shape circle = new Circle(5);

            Console.WriteLine("矩形的面积是：{0}", square.GetArea());
            Console.WriteLine("圆形的面积是：{0}", circle.GetArea());

            Console.ReadKey();
        }
    }

    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Square : Shape
    {
        private double _height;
        private double _width;

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public Square(double h, double w)
        {
            this.Width = w;
            this.Height = h;
        }

        public override double GetArea()
        {
            // 长 * 宽
            return this.Height * this.Width;
        }
    }

    public class Circle : Shape
    {
        private double _r;
        public double R
        {
            get { return _r; }
            set { _r = value; }
        }

        public Circle(double r)
        {
            this.R = r;
        }

        public override double GetArea()
        {
            // 2π* r
            return 2 * Math.PI * this.R;
        }
    }

}
