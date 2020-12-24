using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppPlayground.Playground
{
    public class OopPlayground
    {
        public void VirtualUsage() 
        {
            DerivedC derivedC = new DerivedC();
            derivedC.Invoke();

            int[] intArr = new int[] { 1, 2, 3, 4 };
            intArr.Initialize();

            string s = "sss";

            var t1 = s.GetType();
            var t2 = typeof(string);
        }
    }

    public class BaseC 
    {
        public virtual void Invoke() 
        {
            Console.WriteLine("This is BaseC.Invoke()");
        }

        public void CallNonVirtual() 
        {
        
        }
    }

    public class DerivedC : BaseC
    {
        public override void Invoke()
        {
            //base.Invoke();
            Console.WriteLine("This is DerivedC.Invoke()");
        }

        //public override void CallNonVirtual() 
        //{
        
        //}
    }

    /// <summary>
    /// 
    /// </summary>
    public abstract class AbstBase 
    {
        public abstract void AInvoke();
        public void Invoke() 
        {
            Console.WriteLine("This is AbstBase.Invoke()");
        }
    }

    public class ADerived : AbstBase
    {
        public override void AInvoke()
        {
            base.Invoke();
            throw new NotImplementedException();
        }
    }

}
