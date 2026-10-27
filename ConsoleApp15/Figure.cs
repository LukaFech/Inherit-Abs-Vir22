using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    internal abstract class Figure
    {
        public abstract void Get_s();
    }
    internal class Rectangle : Figure
    {
        int _a;
        int _b;
        public Rectangle(int a, int b)
        {
            _a = a;
            _b = b;
        }
        public override void Get_s()
        {
            Console.WriteLine("Rectangle");
            Console.WriteLine(_a * _b);
        }
    }
    internal class Circle : Figure
    {
        int R;
        public Circle(int r)
        {
            R = r;
        }
        public override void Get_s()
        {
            Console.WriteLine("Circle");
            Console.WriteLine(3.14*R*R);
        }
    }
    internal class Right_Tr : Figure
    {
        int A;
        int B;
        public Right_Tr(int a, int b)
        {
            A = a;
            B = b;
        }
        public override void Get_s()
        {
            Console.WriteLine("Right_Triangle");
            Console.WriteLine((A*B)/2);
        }
    }
    internal class Trapezoid : Figure
    {
        int A;
        int B;
        int H;
        public Trapezoid(int a, int b, int h)
        {
            A = a;
            B = b;
            H = h;
        }
        public override void Get_s()
        {
            Console.WriteLine("Trapezoid");
            Console.WriteLine(((A * B) / 2)*H);
        }
    }
}
