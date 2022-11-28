using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class Orders
    {
        public int Id { get; set; }
        public string ProductId { get; set; }
        public string CustomerId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ProductCount { get; set; }
        public float Price { get; set; }
    }
}