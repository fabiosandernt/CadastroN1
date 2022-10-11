using Cadastro.Domain.Entities;
using Cadastro.Domain.Interfaces;
using Cadastro.Infrastructure.Data.Common;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Infrastructure.Data.Repositories
{
    public class ProductRepository : EfRepository<Product>, IProductRepository
    {
        public ProductRepository(RegisterContext dbContext)
            : base(dbContext)
        {

        }

        public IEnumerable<Product> GetAllWithClient()
        {
            return _dbContext.Set<Product>().Include(x => x.Client).ToList();
        }
    }
}
