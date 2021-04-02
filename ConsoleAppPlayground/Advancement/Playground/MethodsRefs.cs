using ConsoleAppPlayground.Advancement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlayground.Advancement.Playground
{
    // also add refs - out, in, ref
    public class MethodsRefs
    {
        public void Main() 
        {
            EntityUpdate();
        }

        public void EntityUpdate() 
        {
            Contract contract = new Contract() { Id = 1, Name = "Name" };
            Work(contract);
            Console.WriteLine($"Id : {contract.Id}, Name : {contract.Name};");

            var dict = contract.GetDictionaryCust();
        }

        public void Work(Contract contract) 
        {
            contract.Id += 1;
            contract.Name = "New Name";
        }
    }

    public class Contract 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
