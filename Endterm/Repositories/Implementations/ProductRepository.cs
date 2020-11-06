using Endterm.Data;
using Endterm.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endterm.Repositories.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _dataContext;

        public ProductRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Product> GetByIdAsync(Guid id)
        {
            return await _dataContext.Set<Product>().FindAsync(id);
           
        }
    }
}
