using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlayground.Advancement.Db
{
    public class EfRepository : IEfRepository
    {
        private readonly ProductsContext _productsContext;

        public EfRepository(ProductsContext productsContext)
        {
            _productsContext = productsContext;
        }
    }
}
