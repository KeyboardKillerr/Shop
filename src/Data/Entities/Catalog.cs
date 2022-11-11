using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class Catalog
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
