using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlayground.Advancement.Db.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Amount { get; set; }

        public int CategoryId { get; set; } // foreign key
        public Category Category { get; set; } // navigational property

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public List<User> Users { get; set; } = new List<User>();
    }
}
