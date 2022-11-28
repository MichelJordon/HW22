using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class Products
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Company { get; set; }
        public int ProductCount { get; set; }
        public float Price { get; set; }
    }
}