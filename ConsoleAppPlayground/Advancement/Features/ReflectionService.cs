﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleAppPlayground.Advancement.Features
{
    public class ReflectionService
    {
        public void Main() 
        {
            //Basics();
            Usage();
            LateBinding();
            AttributeUsage();
        }

        // Main functionality on reflection is in System.Reflection 
        public void Basics() 
        {
            // Assembly - class that represents an assembly;
            // AssemblyName - info about assembly
            var assemblyName = Assembly.GetExecutingAssembly().GetName();
            Console.WriteLine("Current assembly name: " 
                + Assembly.GetExecutingAssembly().GetName().FullName);
            Console.WriteLine("Location of the current assembly as an URL: "
                + Assembly.GetExecutingAssembly().GetName().CodeBase);
            Console.WriteLine("Current assembly version: "
                + Assembly.GetExecutingAssembly().GetName().Version);

            // System.Type - incapsulates all the info about type - methods, properties, etc,
            // 
            Type type = typeof(SomeClass);
            MethodInfo methodInfo = type.GetMethod("Add");
            Console.WriteLine("Method name: "
                + methodInfo.Name);
            Console.WriteLine("Method's declaring type: "
                + methodInfo.DeclaringType.Name);
            Console.WriteLine("Method's return type: "
                + methodInfo.ReturnType.Name);
            Console.WriteLine("Method is or not static: "
                + methodInfo.IsStatic);

            MethodInfo[] methods = type.GetMethods();
            ConstructorInfo[] constructors = type.GetConstructors();
            EventInfo[] events = type.GetEvents();
            FieldInfo[] fields = type.GetFields();
            Type[] interfaces = type.GetInterfaces(); // interfaces that this type implements
            MemberInfo[] members = type.GetMembers();
            PropertyInfo[] properties = type.GetProperties();

            Console.WriteLine("Namespace in which type is defined: "
                + type.Namespace);
            Console.WriteLine("IsArray: " + type.IsArray 
                + "IsAbstract: " + type.IsAbstract
                + "IsEnum: " + type.IsEnum);
        }

        public void Usage() 
        {
        
        }

        public void DynamicLoad() 
        {
            // in order to dynamically load assembly into app: use this:
            Assembly assembly = Assembly.LoadFrom("Microsoft.EntityFrameworkCore.dll");
            Console.WriteLine(assembly.FullName);
            Type[] types = assembly.GetTypes(); // get all types from this assembly 
            foreach (var t in types) 
            {
                Console.WriteLine(t.Name);
            }
            assembly = Assembly.Load("Microsoft.EntityFrameworkCore");
        }

        public void LateBinding() 
        {
            // Late binding allows to create objects of type and use while app execution
            // Less safe as it is outside compile time       
            Assembly assembly = Assembly.LoadFrom("ConsoleAppPlayground.dll");
            Type type = assembly.GetType("ConsoleAppPlayground.Advancement.Features.SomeClass", true, true);
            // create instance of the class:
            object obj = System.Activator.CreateInstance(type);
            // Get method Add:
            MethodInfo methodInfo = type.GetMethod("Add");
            // Call method, give it params, and get the result
            object result = methodInfo.Invoke(obj, new object[] { 2, 4 });
            Console.WriteLine(result);
        }

        public void AttributeUsage() 
        {
        
        }
    }

    public class SomeClass 
    {
        public int Id { get; set; }
        private string Name { get; set; }
        public int Add(int i, int j) => i + j;
        public int Mult(int i, int j) => i * j;


    }
}
