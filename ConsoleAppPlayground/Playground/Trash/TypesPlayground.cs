using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlayground.Playground.Trash
{
    public class TypesPlayground
    {
        public void Main() 
        {
            
        }

        public void StructUsage() 
        {
            // C# struct is associated with value-type semantic and a value-type is not required 
            // to have a constructor. CLR (not C#) allows a value-type to have a default constructor 
            // but it is not guaranteed to be always called. To avoid the ambiguity of whether the 
            // default constructor of a value-type would be called or not C# compiler does not insert 
            // a call to a value-type default constructor, and that precludes the definition of one.
            // structs can not have constructor without parameters, but here is how it can be done:
            List<Triangle> triangles = new List<Triangle>();
            for (int i = 0; i < 10000; i++) 
            {
                triangles.Add(new Triangle());
            }
        }

    }

    public class Stuff 
    {
        public int Id { get; set; }
        private string Name { get; set; }
        protected float Price{ get; set; } // only for this class and derived from it 
        internal double Coupon { get; set; } // only for this assembly 
        protected internal int X { get; set; } // either this assembly or types, derived
        private protected int Y { get; set; } // either this assembly or types, derived in this assembly 

    }

    public class ChildStuff : Stuff
    {
        public ChildStuff()
        {
            Id = 1;
            Coupon = 1.2;
            Price = 1.3F;
            //Name = ""; - inaccessible due to protection level 
            X = 1;
            Y = 2;
        }
    }

    public struct Triangle 
    {
        public Triangle(float x1 = 1, float y1 = 1, float x2 = 1, float y2 = 1, float x3 = 1) 
            : this()
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
        }

        public float x1 { get; set; }
        public float y1 { get; set; }
        public float x2 { get; set; }
        public float y2 { get; set; }
        public float x3 { get; set; }
        public float y3 { get; set; }
    }
}
