using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppPlayground.Features
{
    public class Generics
    {
        public void Main() 
        {
        
        }
    }

    public class GenericClass<T, U, W, V, Q, D, P>
        where T : struct
        where U : class
        where W : new() // задать с помощью слова new в качестве ограничения класс или структуру, которые 
        // имеют общедоступный конструктор без параметров
        where V : IPerson
        where Q : Person
        where D : class, IPerson, new() // correct order - class or struct, then interface, then new() 
    {
        //public D GetPerson<T, P>(string Name) 
        //{
        //    return new() D;
        //}
    }

    public interface IPerson 
    {
    
    }

    public class Person 
    {
    
    }
}
