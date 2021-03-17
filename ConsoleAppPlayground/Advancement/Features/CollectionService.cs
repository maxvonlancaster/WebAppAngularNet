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
            ObservableCollectionUsage();
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
            //arrayList.Sort(); -> will throw error - different types
            arrayList.Clear(); // delete all elements from arraylist
        }

        public void ListUsage() 
        {
            List<int> listInt = new List<int>() { 1, 2, 0 };
            listInt.Add(3);
            listInt.AddRange(new int[] { 4, 5 } );
            listInt.AddRange(new [] { 6, 7});
            listInt.AddRange(new List<int>() { 8, 9});
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
            s.Push(new Product() { Id = 1, Name = "1"});
            s.Push(new Product() { Id = 2, Name = "2" });
            s.Push(new Product() { Id = 3, Name = "3" });
            Product last = s.Pop();
            Product p = s.Peek(); // without deletion
        }

        public void DictionaryUsage() 
        {
            // every element is of type KeyValuePair<T, S>;
            Dictionary<string, Product> dict = new Dictionary<string, Product>();
            dict.Add("a", new Product() { Id = 1, Name = "a"});
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
                [1]=0,
                [2]=4,
                [3]=9
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

            products.Add(new Product() { Id = 5, Name = "5"});
            products.RemoveAt(1);
            products[2] = new Product() { Id = 6, Name = "6"};
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
        
        }

        public void IteratorsYieldUsage() 
        {
        
        }

    }
}
