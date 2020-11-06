using Endterm.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Endterm.Models
{
    public class PriceList
    {
        public PriceList(PriceListDTO dto)
        {
            Id = Guid.NewGuid();
            CreatedAt = dto.CreatedAt;
        }
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<PriceListItem> PriceListItems { get; set; }

    }
}
