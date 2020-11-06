using Endterm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endterm.Repositories.Implementations
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(Guid id);
    }
}
