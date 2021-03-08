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
}
