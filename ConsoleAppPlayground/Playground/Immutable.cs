using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ConsoleAppPlayground.Playground
{
    public class Immutable
    {
        public void Main() 
        {
        
        }
    }

    public class MyImmutableClass
    {
        private readonly ReadOnlyCollection<Item> myItems;

        public ReadOnlyCollection<Item> Items 
        {
            get { return myItems; } 
        }

        public MyImmutableClass(List<Item> items)
        {
            myItems = items.AsReadOnly();
        }
    }

    public class Item 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
