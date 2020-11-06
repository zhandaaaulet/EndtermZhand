using Endterm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endterm.Repositories.Interfaces
{
    public interface IPriceListRepository
    {
        Task<bool> AddProduct(PriceList priceList);
    }
}
