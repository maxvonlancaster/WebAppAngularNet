using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlayground.Advancement.Db.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime FoundationDate { get; set; }
        
        public List<Product> Products { get; set; }
    }
}
