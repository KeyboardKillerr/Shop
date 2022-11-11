using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class Order
    {
        public Guid Id { get; } = Guid.NewGuid();
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Guid CatalogId { get; set; }
        public List<Catalog> Catalogs { get; set; } = new List<Catalog>();
        public string Promo { get; set; }
    }
}
