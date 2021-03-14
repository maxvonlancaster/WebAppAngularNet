using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlayground.Advancement.Features
{
    // all collections 
    public class CollectionService
    {
        public void Main() 
        {
        
        }

        // most are from these namespaces:
        // using System.Collections.Generic;
        // using System.Collections;
        // using System.Collections.Specialized;
        // using System.Collections.Concurrent;
        public void ArrayListUsage() 
        {
            ArrayList arrayList = new ArrayList(); // collection of obj -> different types together
            arrayList.Add(1);
            arrayList.Add(3.4);
            arrayList.Add("qwewrewr");
            arrayList.Add('a');
            arrayList.Add(new string[] { "a", "b"});
            foreach (object o in arrayList) 
            {
                Console.WriteLine(o.GetType().Name);
            }
            object someObj = arrayList[1]; // indexator
            arrayList.AddRange(new ArrayList() { 1, 2.0, "qwerty" });
            arrayList.Remove(2.0); // removing of the elem (first occurance)
            arrayList.RemoveAt(3); // removing by index
            arrayList.Reverse();
            if (arrayList.Contains(3.4)) 
            {
                ArrayList newArrayList = arrayList.GetRange(0, 3);
            }
            int index = arrayList.IndexOf('a');
            arrayList.Sort();
            arrayList.Clear(); // delete all elements from arraylist
        }

        public void ListUsage() 
        {
        
        }

        public void LinkedListUsage() 
        {
        
        }

        public void QueueUsage() 
        {
        
        }

        public void StackUsage() 
        {
        
        }

        public void DictionaryUsage() 
        {
        
        }

        public void ObservableCollectionUsage() 
        {
        
        }

        public void IenumerableIenumeratorUsage() 
        {
        
        }

        public void IteratorsYieldUsage() 
        {
        
        }

    }
}
