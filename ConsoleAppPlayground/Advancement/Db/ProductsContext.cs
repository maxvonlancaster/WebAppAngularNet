using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlayground.Advancement.Db
{
    public class ProductsContext : DbContext
    {
        public ProductsContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
    }
}
