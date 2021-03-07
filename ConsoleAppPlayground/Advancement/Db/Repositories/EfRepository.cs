using ConsoleAppPlayground.Advancement.Db.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlayground.Advancement.Db.Repositories
{
    public class EfRepository : IEfRepository
    {
        private List<string> _names { get; } = new List<string>
        {
            "Adam", "Bob", "Alice", "Dave", "Michael",
            "Rich", "Lames", "John", "Jay", "Jack"
        };
        private List<string> _lastNames { get; } = new List<string>
        {
            "Bush", "Clinton", "Raegan", "Carter", "Linkoln",
            "Jefferson", "Stoclasa", "Bauman", "Evans", "Robertson"
        };
        private List<string> _companyNames { get; } = new List<string>
        {
            "Vulcan", "Klingon", "Ferengi", "Borg", "Tatooine",
            "Endore", "Coruscant", "Trantor", "Arrakis", "Dominion"
        };
        private List<string> _companyPrefixes { get; } = new List<string>
        {
            "LTD", "INC", "OOO", "COM", "QWS",
            "NNN", "MMM", "POC", "LLS", "DDD"
        };
        private List<string> _productNames { get; } = new List<string>
        {
            "Book", "Phone", "Chair", "Table", "Backpack",
            "Pants", "Program", "Trip", "Paper", "Pencil"
        };
        private List<string> _productPrefixes { get; } = new List<string>
        {
            "New", "Mega", "Super", "Best", "Chinese",
            "Giga", "Exclusive", "Rare", "Unique", "Original"
        };
        private List<string> _categories { get; } = new List<string>
        {
            "Trade", "Transport", "Leisure", "Software", "Entertainment",
            "Tourism", "Office supply", "Sport", "Cooking", "Plants"
        };

        private readonly ProductsContext _productsContext;

        public EfRepository(ProductsContext productsContext)
        {
            _productsContext = productsContext;
        }

        public void Seed()
        {
            _productsContext.Database.EnsureDeleted();
            _productsContext.Database.EnsureCreated();

            var random = new Random();
            var users = new List<User>();
            var products = new List<Product>();
            var companies = new List<Company>();
            var categories = new List<Category>();
            for (int i = 0; i < 10000; i++) 
            {
                var j = random.Next(10);
                var k = random.Next(10);
                var user = new User() 
                {
                    FirstName = _names[j],
                    LasName = _lastNames[k],
                    UserName = _names[j] + _lastNames[k] + "-" + random.Next(100, 1000),
                    Age = random.Next(18, 90)
                };
                users.Add(user);
            }
            for (int i = 0; i < 10000; i++) 
            {
                var j = random.Next(1, 11);
                var k = random.Next(1, 101);
                var category = _productsContext.Categories
                    .FirstOrDefault(c => c.Id == j);
                var company = _productsContext.Companies
                    .FirstOrDefault(c => c.Id == k);
                var product = new Product() 
                {
                    Name = _productNames[random.Next(10)] + " " 
                    + _productPrefixes[random.Next(10)] + " "
                    + _productPrefixes[random.Next(10)],
                    Price = random.Next(1, 1000),
                    Amount = random.Next(1000),
                    CategoryId = j,
                    CompanyId = k
                };
                products.Add(product);
            }
            for (int i = 0; i < 100; i++) 
            {
                DateTime start = new DateTime(1995, 1, 1);
                int range = (DateTime.Today - start).Days;
                start.AddDays(random.Next(range));
                var company = new Company() 
                {
                    Name = _companyNames[i / 10] + " " + _companyPrefixes[i % 10],
                    FoundationDate = start
                };
                companies.Add(company);
            }
            for (int i = 0; i < 10; i++) 
            {
                var category = new Category() 
                {
                    Name = _categories[i],
                    Description = _categories[i]
                };
                categories.Add(category);
            }
            _productsContext.Users.AddRange(users);
            _productsContext.Companies.AddRange(companies);
            _productsContext.Categories.AddRange(categories);
            _productsContext.Products.AddRange(products);
            _productsContext.SaveChanges();
        }
    }
}
