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
            List<Item> items = new List<Item>() 
            {
                new Item() { Id = 1, Name = "Toothpaste" },
                new Item() { Id = 2, Name = "Shampoo" }
            };

            MyImmutableClass myImmutableClass = new MyImmutableClass(items);

            items.Add( new Item() { Id = 3, Name = "Hairbrush" });
            var itemsNew = myImmutableClass.Items; // 2 items 

            //myImmutableClass.Items = items; -> can not be assigned to - it is readonly
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
            myItems = (new List<Item>(items)).AsReadOnly(); // copying using the constructor 
        }
    }

    public class Item 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
