using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlayground.Playground
{
    public class Types
    {
        public void Main() 
        {
            var triangle = new Triangle();
            DummyClass[] dummies = new DummyClass[1000];

            BaseClass cl = new ChildClass();
            Console.WriteLine(cl.GetType().Name); // outputs ChildClass

            //lock (new Triangle()) { }
        }
    }

    public struct Triangle 
    {
        public Point a;
        public Point b;
        public Point c;

        public Triangle(Point a, Point b, Point c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }

    public struct Point 
    {
        public float x;
        public float y;

        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class DummyClass
    {
        public DummyClass()
        {
            Console.WriteLine("Hello from constructor");
        }
    }

    public interface IInterface 
    {
    
    }

    public abstract class AbstractClass 
    {
    
    }

    public class BaseClass 
    {
        public int Add(int x, int y) 
        {
            return x + y;
        }

        public virtual int Multiply(int x, int y) 
        {
            return x * y;
        }
    }

    public class ChildClass : BaseClass, IInterface
    {
        public new int Add(int x, int y) // shadowing - change functionality of method
        {
            return x + y + 1;
        }

        public override int Multiply(int x, int y)
        {
            return x*x*y*y;
        }
    }

    //[InitOnly]
    public class NewImmutable { }


}
