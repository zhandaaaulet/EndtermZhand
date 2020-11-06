using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endterm.Models
{
    public class PriceListItem
    {
        public Guid Id { get; set; }
        public Guid PriceListId { get; set; }
        public PriceList PriceList { get; set; }
        public Product Product { get; set; }
        public Guid ProductId { get; set; }
    }
}
