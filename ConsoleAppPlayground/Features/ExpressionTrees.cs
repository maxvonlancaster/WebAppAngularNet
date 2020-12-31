using System;
using System.Collections.Generic;
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
    }
}
