using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppPlayground.Advancement.Db.Entities;
using System.Collections.ObjectModel;

namespace ConsoleAppPlayground.Advancement.Features
{
    // all collections 
    public class CollectionService
    {
        public void Main()
        {
            ArrayListUsage();
            IenumerableIenumeratorUsage();
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
            arrayList.Add(new string[] { "a", "b" });
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
            //arrayList.Sort(); -> will throw error - different types
            arrayList.Clear(); // delete all elements from arraylist
        }

        public void ListUsage()
        {
            List<int> listInt = new List<int>() { 1, 2, 0 };
            listInt.Add(3);
            listInt.AddRange(new int[] { 4, 5 });
            listInt.AddRange(new[] { 6, 7 });
            listInt.AddRange(new List<int>() { 8, 9 });
            int index = listInt.IndexOf(5);
            bool isSuccesfulRemoval = listInt.Remove(3);
            listInt.RemoveAt(2);
            listInt.Sort();
            index = listInt.BinarySearch(5);
        }

        public void LinkedListUsage()
        {
            // LinkedList - every element has a link to previous elem and next 
            // every elem is of type LinkedListNode<T>
            // 
            LinkedListNode<string> linkedListNode = new LinkedListNode<string>("a");
            string val = linkedListNode.Value;
            LinkedListNode<string> next = linkedListNode.Next;
            LinkedListNode<string> prev = linkedListNode.Previous; // will be null, as they are not set

            LinkedList<string> ll = new LinkedList<string>();
            ll.AddLast("b"); // putting into the last place
            ll.AddFirst("c"); //
            ll.AddLast("x");
            ll.AddAfter(ll.Last, "d");

            LinkedListNode<string> node = ll.Find("c");
            ll.AddBefore(node, "e");
            ll.Remove(node);
            ll.RemoveLast();
            foreach (var elem in ll)
            {
                Console.WriteLine(elem);
            }
            // + operation of insert is fast
            // - search is slow 
        }

        public void QueueUsage()
        {
            // Queue - first in first out;
            Queue<double> q = new Queue<double>();
            q.Enqueue(1.0); // adds to the end of queue
            q.Enqueue(2.555);
            q.Enqueue(3.14);
            int count = q.Count; // 3
            double first = q.Dequeue(); // first=1.0, q={2.555, 3.14}
            double peeked = q.Peek(); // peeked=2.555, q={2.555, 3.14}, no deletion
        }

        public void StackUsage()
        {
            // Stack - last in first out;
            Stack<Product> s = new Stack<Product>();
            s.Push(new Product() { Id = 1, Name = "1" });
            s.Push(new Product() { Id = 2, Name = "2" });
            s.Push(new Product() { Id = 3, Name = "3" });
            Product last = s.Pop();
            Product p = s.Peek(); // without deletion
        }

        public void DictionaryUsage()
        {
            // every element is of type KeyValuePair<T, S>;
            Dictionary<string, Product> dict = new Dictionary<string, Product>();
            dict.Add("a", new Product() { Id = 1, Name = "a" });
            dict.Add("b", new Product() { Id = 2, Name = "b" });
            dict.Add("c", new Product() { Id = 3, Name = "c" });
            dict.Add("d", new Product() { Id = 4, Name = "d" });

            dict.Remove("b"); // removal by key
            Product p = dict["c"]; // retrieval by key 
            dict["c"] = new Product() { Id = 5, Name = "c" }; // adds new if not exists
            foreach (string s in dict.Keys) { }
            foreach (Product pr in dict.Values) { }

            // starting from c# 6 new way of dict init:
            Dictionary<int, int> dictPowers = new Dictionary<int, int>()
            {
                [1] = 0,
                [2] = 4,
                [3] = 9
            };

        }

        public void ObservableCollectionUsage()
        {
            // notifies outside objects about change in collection;
            ObservableCollection<Product> products = new ObservableCollection<Product>()
            {
                new Product(){ Id = 1, Name = "1"},
                new Product(){ Id = 2, Name = "2"},
                new Product(){ Id = 3, Name = "3"},
                new Product(){ Id = 4, Name = "4"}
            };

            products.CollectionChanged += Products_CollectionChanged;

            products.Add(new Product() { Id = 5, Name = "5" });
            products.RemoveAt(1);
            products[2] = new Product() { Id = 6, Name = "6" };
        }

        private void Products_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: // in case of adding
                    Product product = e.NewItems[0] as Product;
                    Console.WriteLine("New prod added: " + product.Name);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Product productDel = e.OldItems[0] as Product;
                    Console.WriteLine("Prod deleted: " + productDel.Name);
                    break;
                case NotifyCollectionChangedAction.Replace:
                    Product p1 = e.OldItems[0] as Product;
                    Product p2 = e.NewItems[0] as Product;
                    Console.WriteLine($"Product {p1.Name} replaced with product {p2.Name}");
                    break;
            }
        }

        public void IenumerableIenumeratorUsage()
        {
            // thanks to IEnumerable and IEnumerator we can use foreach
            // IEnumerable .GetEnumerator() -> IEnumerator
            // IEnumerator: MoveNext, Current, Reset

            int[] numbers = { 1, 3, 5, 7, 9, 11 };
            IEnumerator ie = numbers.GetEnumerator(); // get the enumerator, current at the beginning throws exception
            while (ie.MoveNext()) // untill it is false, now current is 1 (or 3, 5 depending on iteration)
            {
                int item = (int)ie.Current; // get the element from the current position
                Console.WriteLine(item);
            }
            ie.Reset(); // reset the pointer to the beginning of the array;
            //IEnumerator<int> ieg = (IEnumerator<int>)numbers.GetEnumerator(); // also generic enumerator

            Week week = new Week();
            foreach (var day in week)
            {
                Console.WriteLine(day);
            }
        }

        public void IteratorsYieldUsage()
        {
            // iterator - part of code that uses yield operator for code iteration
            // yield return - defines element to return 
            // yield break - no more elements to return 
            PowersThree powers = new PowersThree();
            foreach (double num in powers)
            {
                Console.WriteLine(num);
            }

            foreach (int i in Powers(2, 10)) // display all powers of 2 up to 10;
            {
                Console.WriteLine(i);
            }

            Months months = new Months();
            foreach (string d in months) 
            {
                Console.WriteLine(d);
            }
            foreach (string s in months.GetMonths(5)) // named iterator
            {
                Console.WriteLine(s);
            }
        }

        public IEnumerable<int> Powers(int number, int exponent) 
        {
            int result = 1;
            for (int i = 0; i < exponent; i++) 
            {
                result = result * number;
                yield return result;
            }
        }

    }


    /// <summary>
    /// Additional classes
    /// </summary>
    /// 
    public class Week : IEnumerable<string>
    {
        string[] days = { "Monday", "Tu", "W", "Th", "F", "Sa", "Su" };
        public IEnumerator<string> GetEnumerator()
        {
            return new WeekEnumerator(days); // our own implementation of enumerator
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return days.GetEnumerator(); // here we return the enumerator of the array 
        }
    }

    public class WeekEnumerator : IEnumerator<string>
    {
        string[] days;
        int position = -1;

        public WeekEnumerator(string[] days)
        {
            this.days = days;
        }

        public string Current
        {
            get
            {
                if (position == -1 || position >= days.Length)
                {
                    return null;
                }
                else
                {
                    return days[position];
                }
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            days = null;
        }

        public bool MoveNext()
        {
            if (position < days.Length)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }
    }

    class PowersThree
    {
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return Math.Pow(i, 3);
            }
        }
    }

    class Months : IEnumerable<string>
    {
        string[] months = { "Jan", "Feb", "Mar"};
        public IEnumerator<string> GetEnumerator()
        {
            for (int i = 0; i < months.Length; i++) 
            {
                yield return months[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < months.Length; i++)
            {
                yield return months[i];
            }
        }

        public IEnumerable<string> GetMonths(int max) 
        {
            for (int i = 0; i < max; i++) 
            {
                if (i == months.Length)
                {
                    yield break;
                }
                else 
                {
                    yield return months[i];
                }
            }
        }
    }
}
