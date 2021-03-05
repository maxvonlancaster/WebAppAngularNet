using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ConsoleAppPlayground.Features
{
    public class ExpressionTrees
    {
        public void Main()
        {
            // expression tree is a data structure that represents executable code
            // An expression tree represents what you want to do, not how you want to do it.

            // This is the most important difference between delegates and expressions. You call 
            // function (a Func<int, int, int>) without ever knowing what it will do with the two integers you passed. 
            // It takes two and returns one, that's the most your code can know.

            Func<int, int, int> func = (a, b) => a + b;
            // Expression trees are not executable code, they are a form of data structure.

            Expression<Func<int, int, int>> expression = (a, b) => a + b;
            // The identical lambda expression shown in the previous example is converted into an expression tree 
            // declared to be of type Expression<T>. The identifier expression is not executable code; it is a data 
            // structure called an expression tree.

            // That means you can't just invoke an expression tree like you could invoke a delegate, but you can analyze it.
            Expression body = expression.Body; // 
            var bodyNodeType = expression.Body.NodeType; // ExpressionType.Add
            var parameters = expression.Parameters; // 
            ParameterExpression firstParameter = expression.Parameters[0]; // 
            ParameterExpression secondParameter = expression.Parameters[1]; // 
            string firstParameterName = expression.Parameters[0].Name; // "a"
            Type firstParameterType = expression.Parameters[0].Type; // System.Int32.
            // `expression.NodeType` returns NodeType.Lambda.
            // `expression.Type` returns Func<int, int, int>.
            // `expression.ReturnType` returns Int32.

            // Expression trees were created in order to make the task of converting code such as a query expression 
            // into a string that can be passed to some other process and executed there. One simply takes code, converts 
            // it into data, and then analyzes the data to find the constituent parts that will be translated into a 
            // string that can be passed to another process

            Func<int, int, int> delegateLambda = expression.Compile();
            // 
        }

        public void AnotherOne()
        {
            IEnumerable<Product> products = GetProducts();
            var forSale = products
                .Where(x => x.IsForSale)
                .ToList();


        }

        public IEnumerable<Product> GetProducts() 
        {
            return new List<Product>() 
            {
                new Product(){ Id = 0, Name = "Sample", Price = 10, IsForSale = true },
                new Product(){ Id = 1, Name = "Sample1", Price = 10, IsForSale = true },
                new Product(){ Id = 2, Name = "Sample2", Price = 10, IsForSale = false },
                new Product(){ Id = 3, Name = "Sample3", Price = 10, IsForSale = true },
                new Product(){ Id = 4, Name = "Sample4", Price = 10, IsForSale = true },
                new Product(){ Id = 5, Name = "Sample5", Price = 100, IsForSale = true },
                new Product(){ Id = 6, Name = "Sample6", Price = 100, IsForSale = false },
                new Product(){ Id = 7, Name = "Sample7", Price = 100, IsForSale = true },
                new Product(){ Id = 8, Name = "Sample8", Price = 100, IsForSale = true },
                new Product(){ Id = 9, Name = "Sample9", Price = 100, IsForSale = false },
                new Product(){ Id = 10, Name = "Sample10", Price = 10, IsForSale = false },
                new Product(){ Id = 11, Name = "Sample11", Price = 10, IsForSale = true },
                new Product(){ Id = 12, Name = "Sample12", Price = 10, IsForSale = true },
                new Product(){ Id = 13, Name = "Sample13", Price = 100, IsForSale = false },
                new Product(){ Id = 14, Name = "Sample14", Price = 50, IsForSale = true },
                new Product(){ Id = 15, Name = "Sample15", Price = 10, IsForSale = false },
                new Product(){ Id = 16, Name = "Sample16", Price = 10, IsForSale = true }
            };
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsForSale { get; set; }
    }
}
