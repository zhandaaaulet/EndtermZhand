using Endterm.Data;
using Endterm.Models;
using Endterm.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endterm.Repositories.Implementations
{
    public class PriceListRepository : IPriceListRepository
    {
        private readonly DataContext _dataContext;

        public PriceListRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<bool> AddProduct(PriceList priceList)
        {
            _dataContext.PriceLists.Add(priceList);
            return (await _dataContext.SaveChangesAsync() > 0);
        }
    }
}
