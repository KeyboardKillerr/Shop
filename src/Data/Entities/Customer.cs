using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class Customer
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Guid Token { get; set; } = Guid.NewGuid();
        public DateTime TokenTime { get; set; } = DateTime.Now.AddHours(3);
    }
}
