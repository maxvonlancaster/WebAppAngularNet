using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlayground.Playground
{
    public class StaticInterfaceDefaultImpl
    {
        public void Main()
        {
            Trait trait = new Trait();
            trait.GetNumber(1); // wow, default implementation of interface method :)
        }
    }

    public interface ITrait { }
    public class Trait : ITrait { }


    public static class ExtensionMethods 
    {
        public static int GetNumber(this ITrait trait, int i) { return i + 1; }
    }
}
